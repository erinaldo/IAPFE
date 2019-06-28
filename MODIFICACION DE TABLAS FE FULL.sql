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


select * from master..DatosProveedorFE

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

select * from bdNava01..mstCondicionNC_ND
create table mstCondicionNC_ND
(
	TipoDoc		char(2),
	Codcon		char(2),
	NomCodconNC varchar(50),
	CodigoSunat int,
	primary key(TipoDoc,Codcon)
)

insert into mstCondicionNC_ND select * from bdNava01..mstCondicionNC_ND


alter table tbl01vta
add CodigoSunatTipoIgv  int

update tbl01vta set CodigoSunatTipoIgv=1


--------- INICIO TELESOLUCIONES --------------
SELECT * FROM mst01fac

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
TeleSol_IdFactura varchar(25),
TeleSol_FechaEmitidoBaja datetime,TeleSol_IdComunicacionBaja varchar(250),TeleSol_TicketConstancia varchar(max),
TeleSol_digestValueBajaHash varchar(max),TeleSol_SignatureValuebaja_Firma varchar(max)



create table DatosEmpresa
(
	NombreEmpresa varchar(500),
	RucEmpresa varchar(11)
)
--solo 1
insert into DatosEmpresa values('Grupo IAP','20600085612')
insert into DatosEmpresa values('Consorcio','10461199599')

