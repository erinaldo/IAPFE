ALTER procedure [dbo].[usp_SunatTelesoluciones_EnviarFactura]

(
	@cdocu char(2),
	@ndocu char(12)
)
as
begin
		select
		
		case 
			when f.cdocu='01' then 'F'+left(f.ndocu,3) --falta poner las notas en referencia
			when f.cdocu='03' then 'B'+left(f.ndocu,3)
			when f.cdocu='07' then
				 case 
					when f.crefe='01' then 'F' +left(f.ndocu,3)
					when f.crefe='03' then 'B' +left(f.ndocu,3)
					when LTRIM(RTRIM(f.crefe))='' THEN 
												CASE WHEN td.CodigoSunat=6 THEN 'F' +left(f.ndocu,3)
													 when td.CodigoSunat=1 THEN 'B' +left(f.ndocu,3)
												END
												
				 end
			when f.cdocu='08' then
				 case 
					when f.crefe='01' then 'F' +left(f.ndocu,3)
					when f.crefe='03' then 'B' +left(f.ndocu,3)
					when LTRIM(RTRIM(f.crefe))='' THEN 
												CASE WHEN td.CodigoSunat=6 THEN 'F' +left(f.ndocu,3)
													 when td.CodigoSunat=1 THEN 'B' +left(f.ndocu,3)
												END
												
				 end
		end serie,
		cast(right(f.ndocu,8) as int) as numero,
		ABS(f.tota) as totalVentaGravada,
		cast(case when f.codvta='04' then f.tota else 0 end as numeric(12,2))  as totalVentaInafecta,
		0 as totalVentaExonerada,
		ABS(cast(f.toti as numeric(12,2))) as sumatoriaIgv,
		0 as sumatoriaIsc,
		ABS(cast(f.totn as numeric(12,2))) total,
		CASE f.mone WHEN 'S' THEN 'PEN' ELSE 'USD' END as tipoMoneda,
		(select round(sum((df.preu * df.cant * (df.dsct/100))),2) from dtl01fac df where df.cdocu=f.cdocu and df.ndocu=f.ndocu) descuentoGlobal,
		0 as porcentajeDescuentoGlobal,
		(select round(sum((df.preu * df.cant * (df.dsct/100))),2) from dtl01fac df where df.cdocu=f.cdocu and df.ndocu=f.ndocu) totalDescuento,
		0 as importePercepcion,
		0 as porcentajePercepcion,
		--f.crefe as docRelacionadaCdocu,
		--f.nrefe as docRelacionadaNdocu,
		'' as docRelacionadaCdocu,
		'' as docRelacionadaNdocu,
		case when ndge<>'' then '09' else '' end guiasRelacionadaTipo,
		ndge as guiasRelacionadaNro,
		LEFT(ndge,3) as guiasRelacionadaSerie,
		td.CodigoSunat as receptorTipo, --6 factura 
		right(replace(rtrim(ltrim(c.ruccli)),'DNI',''),15) receptorNumero,
		f.nomcli as ReceptorRazonSocial
	 from mst01fac f
	 --inner join dtl01fac df on df.cdocu=f.cdocu and df.ndocu=f.ndocu
	 inner join tbl01doc d on f.cdocu=d.cdocu
	 inner join mst01cli c on c.codcli=f.codcli
	 inner join mstTipoDocumento td on td.Coddocide=c.coddocide
	 --left join  mstCondicionNC_ND cnc on cnc.Codcon=f.codvta and cnc.TipoDoc=f.cdocu
	 left join  tbl01cdv cv on cv.codcdv=f.Codcdv
	 where f.cdocu=@cdocu and f.ndocu=@ndocu
end




ALTER procedure [dbo].[usp_SunatTelesoluciones_EnviarFacturaDetalle]
(
@cdocu char(2),
@ndocu char(12)
)
as
begin
declare @igv numeric(12,2)
select @igv=((i_g_v/100)+1) from psn0100
select 
case when left(df.codi,2)='07' then 'ZZ' else 'NIU' end as unidad_de_medida,
df.cant as cantidad,
LTRIM(df.descr) as descripcion,
ABS(df.tota) valorVenta,
cast((df.preu) as numeric(22,10)) as valorUnitario,
cast((df.preu*@igv) as numeric(22,10)) as precioVentaUnitario,
'01' as tipoPrecioVentaUnitario,
ABS(cast((df.totn-df.tota) as numeric(22,10))) as montoAfectacionIgv,
'10' as tipoAfectacionIgv,
df.codf as codigoProducto,
cast(((df.preu*(df.dsct/100))) as numeric(14,2))  as descuento

from dtl01fac df
where df.cdocu=@cdocu and df.ndocu=@ndocu and df.codi<>'0000-000000'
end




/* GUARDANDO RESPUESTA DE CONSTANCIA */

ALTER procedure [dbo].[usp_SunatGuardarRespuestaSunatTelesoluciones]
(
	@flg_fe int,
 	@TeleSol_Serie varchar(4),
	@TeleSol_Numero varchar(15),
	@TeleSol_FechaEmitido datetime,
	@TeleSol_Emitido varchar(15),
	@TeleSol_Baja varchar(15),
	@TeleSol_DigestValue_Hash varchar(max),
	@TeleSol_SignatureValue_Firma varchar(max),
	@TeleSol_IdConstancia varchar(15),
	@TeleSol_IdRespuesta varchar(15),
	@TeleSol_CodigoRespuestaSunat varchar(15),
	@TeleSol_NotaAsociada varchar(500),
	@TeleSol_Descripcion varchar(1500),
	@TeleSol_IdFactura varchar(25)
)
as
begin
	declare @cdocu	char(2),@ndocu  char(12)
	set @cdocu=(case left(@TeleSol_Serie,1) when 'F' THEN '01' WHEN 'B' THEN '03' END)
	SET @ndocu=RIGHT(@TeleSol_Serie,3) + '-' + right('00000000'+@TeleSol_Numero,8)
	
	update mst01fac
	set 
	flg_fe=@flg_fe,
	TeleSol_Serie=@TeleSol_Serie,
	TeleSol_Numero=@TeleSol_Numero,
	TeleSol_FechaEmitido=@TeleSol_FechaEmitido,
	TeleSol_Emitido=@TeleSol_Emitido,
	TeleSol_Baja=@TeleSol_Baja,
	TeleSol_DigestValue_Hash=@TeleSol_DigestValue_Hash,
	TeleSol_SignatureValue_Firma=@TeleSol_SignatureValue_Firma,
	TeleSol_IdConstancia=@TeleSol_IdConstancia,
	TeleSol_IdRespuesta=@TeleSol_IdRespuesta,
	TeleSol_CodigoRespuestaSunat=@TeleSol_CodigoRespuestaSunat,
	TeleSol_NotaAsociada=@TeleSol_NotaAsociada,
	TeleSol_Descripcion=@TeleSol_Descripcion,
	TeleSol_IdFactura=@TeleSol_IdFactura
	where cdocu=@cdocu and ndocu=@ndocu
end




/*  MODIFCACION DE TABLAS */
alter table mst01fac
add 
TeleSol_Serie varchar(4),
TeleSol_Numero varchar(15),
TeleSol_FechaEmitido datetime,
TeleSol_Emitido varchar(15),
TeleSol_Baja varchar(15),
TeleSol_DigestValue_Hash varchar(max),
TeleSol_SignatureValue_Firma varchar(max),
TeleSol_IdConstancia varchar(15),
TeleSol_IdRespuesta varchar(15),
TeleSol_CodigoRespuestaSunat varchar(15),
TeleSol_NotaAsociada varchar(500),
TeleSol_Descripcion varchar(1500),
TeleSol_IdFactura varchar(25)
TeleSol_FechaEmitidoBaja datetime,TeleSol_IdComunicacionBaja varchar(250),TeleSol_TicketConstancia varchar(max),
TeleSol_digestValueBajaHash varchar(max),TeleSol_SignatureValuebaja_Firma varchar(max)


-- GUARDAR RESPUESTA DE BAJA SUNAT
CREATE procedure [dbo].[usp_SunatGuardarRespuestaAnulacionSunatTelesoluciones]
(
 	@TeleSol_Serie varchar(4),
	@TeleSol_Numero varchar(15),
	@TeleSol_FechaEmitido datetime,
	@TeleSol_IdComunicacionBaja varchar(250),
	@TeleSol_TicketConstancia varchar(max),
	@TeleSol_digestValueBajaHash varchar(max),
	@TeleSol_SignatureValuebaja_Firma varchar(max)
)
as
begin
	declare @cdocu	char(2),@ndocu  char(12)
	set @cdocu=(case left(@TeleSol_Serie,1) when 'F' THEN '01' WHEN 'B' THEN '03' END)
	SET @ndocu=RIGHT(@TeleSol_Serie,3) + '-' + right('00000000'+@TeleSol_Numero,8)
	
	update mst01fac
	set 
	TeleSol_FechaEmitido=@TeleSol_FechaEmitido,
	TeleSol_IdComunicacionBaja=@TeleSol_IdComunicacionBaja,
	TeleSol_TicketConstancia=@TeleSol_TicketConstancia,
	TeleSol_digestValueBajaHash=@TeleSol_digestValueBajaHash,
	TeleSol_SignatureValuebaja_Firma=@TeleSol_SignatureValuebaja_Firma
	where cdocu=@cdocu and ndocu=@ndocu
end




create procedure [dbo].[usp_SunatGuardarConstanciaSunatTelesoluciones]
(
	@cdocu char(2),
	@ndocu varchar(15),
	@TeleSol_IdConstancia varchar(15),
	@TeleSol_IdRespuesta varchar(15),
	@TeleSol_CodigoRespuestaSunat varchar(15),
	@TeleSol_NotaAsociada varchar(500),
	@TeleSol_Descripcion varchar(1500)
)
as
begin
	
	update mst01fac
	set 
	
	TeleSol_IdConstancia=@TeleSol_IdConstancia,
	TeleSol_IdRespuesta=@TeleSol_IdRespuesta,
	TeleSol_CodigoRespuestaSunat=@TeleSol_CodigoRespuestaSunat,
	TeleSol_NotaAsociada=@TeleSol_NotaAsociada,
	TeleSol_Descripcion=@TeleSol_Descripcion
	where cdocu=@cdocu and ndocu=@ndocu
end
