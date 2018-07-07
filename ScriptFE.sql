/* TABLAS */

alter table tbl01doc
add flg_fe bit

update tbl01doc set flg_fe=1 where persnt=1

alter table tbl01doc
add CodigoSunat int

update tbl01doc set CodigoSunat=1 where cdocu='01'
update tbl01doc set CodigoSunat=2 where cdocu='03'
update tbl01doc set CodigoSunat=3 where cdocu='07'
update tbl01doc set CodigoSunat=4 where cdocu='08'


alter table mst01fac
add flg_fe int

alter table mst01fac
add MensajeFENubefact nvarchar(max)

update mst01fac set flg_fe=0
--update tbl01doc set flg_fe=1 where persnt=1



--<<este campo esta pendiente>>>>

		--alter table mst01fac
		--add flg_enviofe bit
		--update mst01fac set flg_enviofe=0

ALTER TABLE mst01fac
  ADD 	tipo_de_comprobante VARCHAR(10) NULL,
	serie  VARCHAR(10) NULL,
	numero    VARCHAR(10) NULL,
	enlace VARCHAR(MAX) NULL,
	aceptada_por_sunat VARCHAR(10) NULL,
	sunat_description VARCHAR(MAX) NULL,
	sunat_note VARCHAR(50) NULL,
	sunat_responsecode VARCHAR(10) NULL,
	sunat_soap_error VARCHAR(50) NULL,
	pdf_zip_base64 VARCHAR(50) NULL,
	xml_zip_base64 VARCHAR(50) NULL,
	cdr_zip_base64 VARCHAR(50),
	cadena_para_codigo_qr VARCHAR(50) NULL,
	codigo_hash VARCHAR(MAX) NULL,
	enlace_del_pdf VARCHAR(MAX) NULL,
	enlace_del_xml VARCHAR(MAX) NULL,
	enlace_del_cdr VARCHAR(MAX) NULL,
	fe_errors VARCHAR(MAX) NULL,
	fe_codigo VARCHAR(2) NULL,
	enlace_del_pdf_anulado VARCHAR(MAX) NULL

create table DatosProveedorFE
(
	Empresa	varchar(250),
	Ruc		nvarchar(25),
	Link	varchar(250),
	Usuario	varchar(250),
	Clave	varchar(max),
	Ruta	varchar(max),
	Token	varchar(max)
)




insert into DatosProveedorFE values('Nubefact SA','20600695771','https://demo.nubefact.com/login','demo@nubefact.com','demo@nubefact.com',
'https://demo.nubefact.com/api/v1/03989d1a-6c8c-4b71-b1cd-7d37001deaa0','d0a80b88cde446d092025465bdb4673e103a0d881ca6479ebbab10664dbc5677')


create table mstTipoDocumento
(
	Coddocide char(2) primary key ,
	NomCoddocide varchar(50),
	CodigoSunat int
)


insert into mstTipoDocumento values('01','Documento Nacional de Identidad',1)
insert into mstTipoDocumento values('02','Carnet de Fuerza Policial',0)
insert into mstTipoDocumento values('03','Carnet de Fuerzas Armadas',0)
insert into mstTipoDocumento values('04','Carnet de extranjeria',4)
insert into mstTipoDocumento values('05','Ruc',6)
insert into mstTipoDocumento values('07','Pasaporte',7)
insert into mstTipoDocumento values('11','Partida de Nacimiento',0)


create table mstCondicionNC_ND
(
	TipoDoc		char(2),
	Codcon		char(2),
	NomCodconNC varchar(50),
	CodigoSunat int,
	primary key(TipoDoc,Codcon)
)


insert into mstCondicionNC_ND values('07','01','Devolucion Mercaderia',0)
insert into mstCondicionNC_ND values('07','02','Descuento pronto pago',0)
insert into mstCondicionNC_ND values('07','03','Garantia BX 84',0)
insert into mstCondicionNC_ND values('07','04','Devolucion Efectivo BX84',0)
insert into mstCondicionNC_ND values('07','05','Devolucion Gran Venta',0)
insert into mstCondicionNC_ND values('07','06','Descuento Venta',0)
insert into mstCondicionNC_ND values('07','07','Refacturacion',0)
insert into mstCondicionNC_ND values('07','08','Descuento politico',0)
insert into mstCondicionNC_ND values('07','09','Otros Descuentos',0)
insert into mstCondicionNC_ND values('07','10','Anulacion F/B',0)
insert into mstCondicionNC_ND values('07','11','Devolucion Anticipo',0)
insert into mstCondicionNC_ND values('07','12','Devolucion Mercaderia sin Fac',0)
insert into mstCondicionNC_ND values('07','13','Diferencia de Precios',0)
insert into mstCondicionNC_ND values('07','14','Anulacion Parcial',0)
insert into mstCondicionNC_ND values('07','15','Anulacion Total',0)
insert into mstCondicionNC_ND values('07','16','Anulacion Parcial Gra.',0)

insert into mstCondicionNC_ND values('08','01','Interes por mora',1)

insert into mstCondicionNC_ND values('01','01','Mercaderia',1)
insert into mstCondicionNC_ND values('01','02','Servicios',1)
insert into mstCondicionNC_ND values('01','03','Venta Diferida',0)
insert into mstCondicionNC_ND values('01','04','Transferencia Gratuita',0)
insert into mstCondicionNC_ND values('01','05','Anticipo de Mercaderia',4)
insert into mstCondicionNC_ND values('01','06','Anticipo Servicio',0)
insert into mstCondicionNC_ND values('01','07','Venta Exterior',2)
insert into mstCondicionNC_ND values('01','08','Garantia BX',0)
insert into mstCondicionNC_ND values('01','09','Muestra Comercial',0)
insert into mstCondicionNC_ND values('01','10','Mercaderia Separada',0)
insert into mstCondicionNC_ND values('01','11','Mercaderia sin Mov. Stock',0)
insert into mstCondicionNC_ND values('01','12','Reencacuche',0)
insert into mstCondicionNC_ND values('01','15','Licitacion',0)
insert into mstCondicionNC_ND values('01','16','Venta Exonerada',0)

insert into mstCondicionNC_ND values('03','01','Mercaderia',1)
insert into mstCondicionNC_ND values('03','02','Servicios',1)
insert into mstCondicionNC_ND values('03','03','Venta Diferida',0)
insert into mstCondicionNC_ND values('03','04','Transferencia Gratuita',0)
insert into mstCondicionNC_ND values('03','05','Anticipo de Mercaderia',4)
insert into mstCondicionNC_ND values('03','06','Anticipo Servicio',0)
insert into mstCondicionNC_ND values('03','07','Venta Exterior',2)
insert into mstCondicionNC_ND values('03','08','Garantia BX',0)
insert into mstCondicionNC_ND values('03','09','Muestra Comercial',0)
insert into mstCondicionNC_ND values('03','10','Mercaderia Separada',0)
insert into mstCondicionNC_ND values('03','11','Mercaderia sin Mov. Stock',0)
insert into mstCondicionNC_ND values('03','12','Reencacuche',0)
insert into mstCondicionNC_ND values('03','15','Licitacion',0)
insert into mstCondicionNC_ND values('03','16','Venta Exonerada',0)


alter table tbl01vta
add CodigoSunatTipoIgv  int

update tbl01vta set CodigoSunatTipoIgv=1


/*                 FIN TABLAS				*/
ALTER procedure [dbo].[usp_ObtenerDocumentosFBNC]
(
	@cdocu char(2)=null,
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
	f.enlace_del_pdf_anulado
	FROM mst01fac f
	inner join tbl01cdv c on c.codcdv=f.Codcdv
	where 
	--ndocu='001-00000066'
	(@cdocu is null or  f.cdocu in(select Item from dbo.Fn_VS_Split(@cdocu,','))) and 
	CAST(f.fecha AS DATE) between CAST(@fechai AS DATE) and CAST(@fechaf AS DATE) and 
	(@cliente is null or f.nomcli like @cliente+'%') and
	(@documento is null or f.ndocu like @documento+'%') and
	(@enviadosunat is null or f.flg_fe=@enviadosunat) and
	(f.flag in (select cast(Item as char) from dbo.Fn_VS_Split(@STRanulado,',')))
	ORDER BY f.fecha desc
end





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


ALTER procedure [dbo].[usp_ObtenerTipoDocumento]
as
begin
	SELECT cdocu,nomdoc FROM tbl01doc where flg_fe=1
end

create procedure usp_ObtenerDatosProveedorFE
as
begin
	select Empresa,Ruc,Link,Usuario,Clave,Ruta,Token from DatosProveedorFE
end


--select * from mst01cli


ALTER procedure [dbo].[usp_SunatGuardarRespuestaSunat]
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




ALTER procedure [dbo].[usp_SunatEnviarDocumentosFBN_ObtenerDatos]
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
			when f.cdocu='01' then 'F'+left(f.ndocu,3) --falta poner las notas en referencia
			when f.cdocu='03' then 'B'+left(f.ndocu,3)
			when f.cdocu='07' then
				 case 
					when f.crefe='01' then 'F' +left(f.ndocu,3)
					when f.crefe='03' then 'B' +left(f.ndocu,3)
				 end
			when f.cdocu='08' then
				 case 
					when f.crefe='01' then 'F' +left(f.ndocu,3)
					when f.crefe='03' then 'B' +left(f.ndocu,3)
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
		ABS(cast(case when f.Codcdv='04' then 0 else f.toti end as numeric(12,2))) as total_igv,
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
					when f.crefe='01' then 'F' +left(f.ndocu,3)
					when f.crefe='03' then 'B' +left(f.ndocu,3)
				 end
			when f.cdocu='08' then
				 case 
					when f.crefe='01' then 'F' +left(f.ndocu,3)
					when f.crefe='03' then 'B' +left(f.ndocu,3)
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



ALTER procedure [dbo].[usp_SunatEnviarDocumentosFBN_ObtenerDatosDetalle]
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
