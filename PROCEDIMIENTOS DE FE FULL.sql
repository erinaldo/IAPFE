USE [bdNava01]
GO
/****** Object:  StoredProcedure [dbo].[usp_SunatEnviarDocumentosFBN_ObtenerDatos]    Script Date: 28/06/2019 14:43:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--exec usp_SunatEnviarDocumentosFBN_ObtenerDatos '01','f01-00000053'
create procedure [dbo].[usp_SunatEnviarDocumentosFBN_ObtenerDatos]
(
	@cdocu char(2),
	@ndocu char(12)
)
as
begin
		select
		'generar_comprobante' operacion,
		d.CodigoSunat tipo_de_comprobante,
		case 
			when f.cdocu='01' then 'F'+left(REPLACE(f.ndocu,'F','0'),3) --falta poner las notas en referencia
			when f.cdocu='03' then 'B'+left(REPLACE(f.ndocu,'B','0'),3)
			when f.cdocu='07' then
				 case 
					when f.crefe='01' then 'F' +left(REPLACE(f.ndocu,'F','0'),3)
					when f.crefe='03' then 'B' +left(REPLACE(f.ndocu,'B','0'),3)
				 end
			when f.cdocu='08' then
				 case 
					when f.crefe='01' then 'F' +left(REPLACE(f.ndocu,'F','0'),3)
					when f.crefe='03' then 'B' +left(REPLACE(f.ndocu,'B','0'),3)
				 end
		end serie,
		cast(right(f.ndocu,8) as int) as numero,
		1 sunat_transaction, -- 1= venta interna
		td.CodigoSunat cliente_tipo_de_documento,
		right(replace(rtrim(ltrim(c.ruccli)),'DNI',''),15) cliente_numero_de_documento,
		right(f.nomcli,100) cliente_denominacion,
		right(c.dircli,100) cliente_direccion,
		right(c.email,250) cliente_email,
		right(c.email,250) cliente_email_1,
		right(c.email,250) cliente_email_2,
		cast(f.fecha as date) fecha_de_emision,
		cast(f.fven as date) fecha_de_vencimiento,
		case 
			when f.mone='S' THEN 1
			when f.mone='D' THEN 2
		else 3
		end moneda,
		cast(f.tcam as numeric(18,3)) tipo_de_cambio,
		(select cast(i_g_v as numeric(4,2)) from psn0100) porcentaje_de_igv,
		(select sum(dsct) from dtl01fac df where df.cdocu=f.cdocu and df.ndocu=f.ndocu) descuento_global,
		--round((df.preu * (df.dsct/100)),2) as total_descuento,
		(select round(sum((df.preu * (df.dsct/100))),2) from dtl01fac df where df.cdocu=f.cdocu and df.ndocu=f.ndocu) as total_descuento,
		case when f.Codcdv='05' then f.tota else 0 end  as total_anticipo,
		--cast(df.tota as numeric(12,2)) total_gravada,
		ABS(f.tota) as total_gravada,
		cast(case when f.Codcdv='04' then f.tota else 0 end as numeric(12,2))  as total_inafecta, 
		cast(0 as numeric(12,2)) as total_exonerada,
		--ABS(cast(case when f.Codcdv='04' then 0 else f.toti end as numeric(12,2))) as total_igv,
		ABS(f.toti) as total_igv,
		ABS(cast(case when f.Codcdv='04' then f.tota else 0 end as numeric(12,2))) as total_gratuita,
		ABS(cast(0 as numeric(12,2))) as total_otros_cargos,
		ABS(cast(f.totn as numeric(12,2))) total,
		'' as percepcion_tipo,
		0 as percepcion_base_imponible,
		0 as total_percepcion,
		0 as total_incluido_percepcion,
		'false' as detraccion,
		f.observ as observaciones,
		case 
			when f.cdocu in('07','08') then 
				case 
					when crefe='01' then 1 else 2 
				end 
			else 0
		end documento_que_se_modifica_tipo,
		case 
			when f.cdocu='07' then
				 case 
					when f.crefe='01' then 'F' +left(REPLACE(f.ndocu,'F','0'),3)
					when f.crefe='03' then 'B' +left(REPLACE(f.ndocu,'B','0'),3)
				 end
			when f.cdocu='08' then
				 case 
					when f.crefe='01' then 'F' +left(REPLACE(f.ndocu,'F','0'),3)
					when f.crefe='03' then 'B' +left(REPLACE(f.ndocu,'B','0'),3)
				 end
			else
				''
		end documento_que_se_modifica_serie,
		case 
			when f.cdocu in('07','08') then cast(right(f.nrefe,8) as int)
			else 0
		end documento_que_se_modifica_numero,
		case 
			f.cdocu
			when '07' then 
			(select cast(CodigoSunat as int) from mstCondicionNC_ND n where n.tipodoc=f.cdocu and n.codcon=ctrans) 
		else 0 
		end tipo_de_nota_de_credito,
		case 
			f.cdocu
			when '08' then 
			(select cast(CodigoSunat as nvarchar) from mstCondicionNC_ND n where n.tipodoc=f.cdocu and n.codcon=ctrans) 
		else '' 
		end tipo_de_nota_de_debito,
		'true' as enviar_automaticamente_a_la_sunat,
		'true' as enviar_automaticamente_al_cliente,
		'' as codigo_unico,
		cv.nomcdv as condiciones_de_pago,
		'' as medio_de_pago,
		f.placacar as placa_vehiculo,
		f.orde as orden_compra_servicio,
		'' as tabla_personalizada_codigo,
		'A4' as formato_de_pdf
	 from mst01fac f
	 --inner join dtl01fac df on df.cdocu=f.cdocu and df.ndocu=f.ndocu
	 inner join tbl01doc d on f.cdocu=d.cdocu
	 inner join mst01cli c on c.codcli=f.codcli
	 inner join mstTipoDocumento td on td.Coddocide=c.coddocide
	 --left join  mstCondicionNC_ND cnc on cnc.Codcon=f.codvta and cnc.TipoDoc=f.cdocu
	 left join  tbl01cdv cv on cv.codcdv=f.Codcdv
	 where f.cdocu=@cdocu and f.ndocu=@ndocu
end


------------------------------------------------------------------

USE [bdNava01]
GO
/****** Object:  StoredProcedure [dbo].[usp_SunatEnviarDocumentosFBN_ObtenerDatosDetalle]    Script Date: 28/06/2019 14:44:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[usp_SunatEnviarDocumentosFBN_ObtenerDatosDetalle]
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
		df.codf		as codigo,
		LTRIM(df.descr)	as descripcion,
		df.cant		as cantidad,
		df.preu		as valor_unitario,
		cast((df.preu*@igv) as numeric(22,10)) as precio_unitario,
		cast(((df.preu*(df.dsct/100))) as numeric(14,2))  as descuento,
		--df.cant*(df.preu-(df.preu*(df.dsct/100))) subtotal
		ABS(df.tota) subtotal,
		1 as tipo_de_igv,
		ABS(cast((df.totn-df.tota) as numeric(22,10))) as igv,
		ABS(df.totn) as total,
		0 as anticipo_regularizacion,
		'' as anticipo_documento_serie,
		'' as anticipo_documento_numero
	 from dtl01fac df
	where df.cdocu=@cdocu and df.ndocu=@ndocu and df.codi<>'0000-000000'
end


------------------------------------------------------------------------------

USE [bdNava01]
GO
/****** Object:  StoredProcedure [dbo].[usp_SunatGuardarRespuestaSunat]    Script Date: 28/06/2019 14:45:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[usp_SunatGuardarRespuestaSunat]
(
	@cdocu	char(2),
	@ndocu  char(12),
	@flg_fe int,
 	@tipo_de_comprobante VARCHAR(10) ,
	@serie  VARCHAR(10) ,
	@numero    VARCHAR(10),
	@enlace VARCHAR(MAX) ,
	@aceptada_por_sunat VARCHAR(10) ,
	@sunat_description VARCHAR(MAX) ,
	@sunat_note VARCHAR(50),
	@sunat_responsecode VARCHAR(10),
	@sunat_soap_error VARCHAR(50),
	@pdf_zip_base64 VARCHAR(50),
	@xml_zip_base64 VARCHAR(50),
	@cdr_zip_base64 VARCHAR(50),
	@cadena_para_codigo_qr VARCHAR(50),
	@codigo_hash VARCHAR(MAX),
	@enlace_del_pdf VARCHAR(MAX),
	@enlace_del_xml VARCHAR(MAX),
	@enlace_del_cdr VARCHAR(MAX),
	@fe_errors VARCHAR(MAX),
	@fe_codigo VARCHAR(2)
)
as
begin
	update mst01fac
	set 
	flg_fe =@flg_fe,
 	tipo_de_comprobante=@tipo_de_comprobante ,
	serie =CASE WHEN @flg_fe IN(0,1) then @serie else serie end ,
	numero=CASE WHEN @flg_fe IN(0,1) then @numero else serie end ,
	enlace=@enlace,
	aceptada_por_sunat=@aceptada_por_sunat ,
	sunat_description =@sunat_description ,
	sunat_note =@sunat_note ,
	sunat_responsecode=@sunat_responsecode ,
	sunat_soap_error =@sunat_soap_error,
	pdf_zip_base64 =@pdf_zip_base64 ,
	xml_zip_base64 =@xml_zip_base64 ,
	cdr_zip_base64 =@cdr_zip_base64 ,
	cadena_para_codigo_qr=@cadena_para_codigo_qr ,
	codigo_hash =@codigo_hash ,
	enlace_del_pdf =case when @flg_fe in(0,1) then @enlace_del_pdf else enlace_del_pdf end,
	enlace_del_xml =@enlace_del_xml,
	enlace_del_cdr =@enlace_del_cdr,
	fe_errors =@fe_errors,
	fe_codigo =@fe_codigo,
	enlace_del_pdf_anulado =case when @flg_fe =2 then @enlace_del_pdf else enlace_del_pdf_anulado end
	where cdocu=@cdocu and ndocu=@ndocu
end


-----------------------------------------------------------------------------------

USE [bdNava01]
GO
/****** Object:  StoredProcedure [dbo].[usp_ObtenerTipoDocumento]    Script Date: 28/06/2019 14:46:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[usp_ObtenerTipoDocumento]
as
begin
	SELECT cdocu,nomdoc FROM tbl01doc where flg_fe=1
end
-------------------------------------------------------------------

USE [bdNava01]
GO
/****** Object:  StoredProcedure [dbo].[usp_ObtenerDocumentosDetalleFBNC]    Script Date: 28/06/2019 14:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER procedure [dbo].[usp_ObtenerDocumentosDetalleFBNC]
(
	@cdocu char(2),
	@ndocu varchar(25)
)
as
begin
	select codi,codf,marc,descr,umed,cant,preu,cant*preu Total
	from dtl01fac 
	where cdocu=@cdocu and ndocu=@ndocu
end

----------------------------------------

USE [bdNava01]
GO
/****** Object:  StoredProcedure [dbo].[usp_ObtenerDocumentosFBNC]    Script Date: 28/06/2019 14:47:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER procedure [dbo].[usp_ObtenerDocumentosFBNC]
(
	@cdocu char(250)=null,
	@fechai datetime=null,
	@fechaf	datetime=null,
	@cliente varchar(250)=null,
	@documento varchar(25)=null,
	@enviadosunat int,
	@anulado int
)
as
begin

declare @STRanulado varchar(25)

	if @enviadosunat=2
		set @enviadosunat=null

	if @anulado=0
	begin
		set @STRanulado= '0,1,2'
	end
	else
	begin
		set @STRanulado='*'
	end
	
	if @cliente=''
		set @cliente=null
	if @documento=''
		set @documento=null
	
	SELECT f.fecha,f.cdocu,f.ndocu,f.drefe,f.crefe,f.nrefe,f.nomcli,f.ruccli,c.codcdv,c.nomcdv,
	f.flag,case f.flag when '*' then 'Anulado' when '0' then 'Emitido' when '1' then 'Amortizado' end Estado,f.mone,f.tcam,f.tota,f.toti,f.totn,
	isnull(f.flg_fe,0) flg_fe,case  isnull(f.flg_fe,0) when 0 then 'Emitido' when 1 then 'Enviado' end EstadoFe,
	-- sunat
	f.serie,
	f.numero,
	f.enlace,
	case rtrim(isnull(f.aceptada_por_sunat,'False')) when 'True' then 1 else 0  end aceptada_por_sunat,
	f.sunat_description,
	f.sunat_note,
	f.sunat_responsecode,
	f.sunat_soap_error,
	f.enlace_del_pdf,
	f.enlace_del_xml,
	f.enlace_del_cdr,
	f.tipo_de_comprobante,
	f.motanu,
	f.enlace_del_pdf_anulado,
	f.TeleSol_Serie,
	f.TeleSol_Numero,
	f.TeleSol_FechaEmitido,
	f.TeleSol_Emitido,
	f.TeleSol_Baja,
	f.TeleSol_DigestValue_Hash,
	f.TeleSol_SignatureValue_Firma,
	f.TeleSol_IdConstancia,
	f.TeleSol_IdRespuesta,
	f.TeleSol_CodigoRespuestaSunat,
	f.TeleSol_NotaAsociada,
	f.TeleSol_Descripcion,
	f.TeleSol_IdFactura,
	f.TeleSol_IdComunicacionBaja
	FROM mst01fac f
	inner join tbl01cdv c on c.codcdv=f.Codcdv
	where 
	--ndocu='001-00000066'
	(@cdocu is null or  f.cdocu in(select Item from dbo.Fn_VS_Split(@cdocu,','))) and 
	CAST(f.fecha AS DATE) between CAST(@fechai AS DATE) and CAST(@fechaf AS DATE) and 
	(@cliente is null or f.nomcli like @cliente+'%') and
	(@documento is null or f.ndocu like @documento+'%') and
	(@enviadosunat is null or isnull(f.flg_fe,0)=@enviadosunat) and
	(f.flag in (select cast(Item as char) from dbo.Fn_VS_Split(@STRanulado,',')))
	ORDER BY f.fecha desc
end


----------------------------------------

USE [bdNava01]
GO
/****** Object:  StoredProcedure [dbo].[usp_SunatGuardarConstanciaSunatTelesoluciones]    Script Date: 28/06/2019 14:47:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER procedure [dbo].[usp_SunatGuardarConstanciaSunatTelesoluciones]
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


---------------------------------.
USE [bdNava01]
GO
/****** Object:  StoredProcedure [dbo].[usp_SunatGuardarRespuestaAnulacionSunatTelesoluciones]    Script Date: 28/06/2019 14:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER procedure [dbo].[usp_SunatGuardarRespuestaAnulacionSunatTelesoluciones]
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

---------------------------------------------------------
USE [bdNava01]
GO
/****** Object:  StoredProcedure [dbo].[usp_SunatGuardarRespuestaSunatTelesoluciones]    Script Date: 28/06/2019 14:56:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

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

--------------------------------------------------------

USE [bdNava01]
GO
/****** Object:  StoredProcedure [dbo].[usp_SunatTelesoluciones_EnviarFacturaDetalle]    Script Date: 28/06/2019 14:56:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

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

-----------------------------------------

USE [bdNava01]
GO
/****** Object:  StoredProcedure [dbo].[usp_SunatTelesoluciones_EnviarFactura]    Script Date: 28/06/2019 14:56:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

---------------------------------------------------------------------------------------
USE [bdNava01]
GO
/****** Object:  StoredProcedure [dbo].[USP_EliminarDocVenta2016XndocuCodDocu]    Script Date: 28/06/2019 14:58:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER  procedure [dbo].[USP_EliminarDocVenta2016XndocuCodDocu]
@ndocu char(12),
@cdocu char(2)

as
DECLARE @flag CHAR(1),@mes char(2),@compro char(6),@Ano int
begin transaction
SELECT @flag=flag,@mes=month(fecha),@compro= substring(compro,4,6),@Ano=year(fecha) FROM MST01fac WITH (nolock) WHERE NDOCU=@ndocu AND CDOCU=@cdocu

if(@flag<>'*')
begin
	raiserror('El documento no esta anulado, anule el documento y vuelva a intentarlo',16,1)
	return
end

IF @flag='*' 
BEGIN

	if @Ano not in(2017,2018,2019)
		begin
			raiserror('No esta implementado la eliminacion de documentos del año del documento',16,1)
			return
		end

	delete from  DTL01fac where cdocu=@cdocu and ndocu=@ndocu
	if @Ano=2019
		begin
			delete from cgm01022019 where origen='03' and compro=@compro and coddoc=@cdocu and nrodoc=@ndocu and mes_as=@mes	
		end
	if @Ano=2018
		begin
			delete from cgm01022018 where origen='03' and compro=@compro and coddoc=@cdocu and nrodoc=@ndocu and mes_as=@mes	
		end
	if @Ano=2017
		begin
			delete from cgm01022017 where origen='03' and compro=@compro and coddoc=@cdocu and nrodoc=@ndocu and mes_as=@mes	
		end
	


	delete from mst01fac where  cdocu=@cdocu and ndocu=@ndocu
	delete from dbo.Dtl_Anulacion_Doc where cdocu=@cdocu and ndocu=@ndocu
	delete from mst01snt_fac where  cdocu=@cdocu and ndocu=@ndocu


END
commit



-----------------------------------------

--ADICIONALES
USE [bdNava01]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_VS_Split]    Script Date: 28/06/2019 15:34:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Fn_VS_Split] (
      @InputString                  VARCHAR(MAX),
      @Delimiter                    VARCHAR(MAX)
)

RETURNS @Items TABLE (
      Item                          VARCHAR(MAX)
)

AS
--------------------------------
--ANDY V. 03/11/2014
--CHISTEMAS
--DESCRIPTION: THIS FUNCTION RETURN TO STRING IN ROW
------------------------------------
BEGIN
      IF @Delimiter = ' '
      BEGIN
            SET @Delimiter = ','
            SET @InputString = REPLACE(@InputString, ' ', @Delimiter)
      END

      IF (@Delimiter IS NULL OR @Delimiter = '')
            SET @Delimiter = ','

      DECLARE @Item           VARCHAR(MAX)
      DECLARE @ItemList       VARCHAR(MAX)
      DECLARE @DelimIndex     INT

      SET @ItemList = @InputString
      SET @DelimIndex = CHARINDEX(@Delimiter, @ItemList, 0)
      WHILE (@DelimIndex != 0)
      BEGIN
            SET @Item = SUBSTRING(@ItemList, 0, @DelimIndex)
            INSERT INTO @Items VALUES (@Item)


            SET @ItemList = SUBSTRING(@ItemList, @DelimIndex+1, LEN(@ItemList)-@DelimIndex)
            SET @DelimIndex = CHARINDEX(@Delimiter, @ItemList, 0)
      END -- End WHILE

      IF @Item IS NOT NULL 
      BEGIN
            SET @Item = @ItemList
            INSERT INTO @Items VALUES (@Item)
      END

      ELSE INSERT INTO @Items VALUES (@InputString)

      RETURN

END 



-----------------------------------------
ALTER procedure [dbo].[USP_DATOSPROVEEDOR_FE]
(
	@IdEmpresa int,
	@BaseDeDatos varchar(50)
)
AS
BEGIN

	declare @rucempresa varchar(11)
	if(@BaseDeDatos='Bdnava01')
		select @rucempresa=RucEmpresa from bdNava01.dbo.DatosEmpresa
	if(@BaseDeDatos='Bdnava02')
		select @rucempresa=RucEmpresa from bdNava02.dbo.DatosEmpresa

	SELECT Usuario,Clave,Ruta,Token FROM DatosProveedorFE where BaseDeDatos=@BaseDeDatos and Ruc=@rucempresa

END