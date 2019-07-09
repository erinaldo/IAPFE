create procedure USP_SEL_EmailCliente
(
	@ruccli varchar(11)
)
as
begin
	select top 1 email,nomcli from mst01cli where ruccli=@ruccli;
end

create table tbl_EnvioDocumentosElectronicos
(
	Id numeric(18,0) identity(1,1) primary key,
	cdocu char(2),
	ndocu varchar(25),
	flag_enviado bit default(0),
	FechaEnvio datetime,
	FechaRegistro datetime
)

alter PROCEDURE USP_SEL_ObtenerDocumentosPendientes_EnvioFE
as
begin
	declare @ruc varchar(11),@NombreProveedorFE varchar(100);
	select @ruc=RucEmpresa from DatosEmpresa
	select @NombreProveedorFE=Empresa from master..DatosProveedorFE where Ruc=@ruc
	select Id,e.cdocu,e.ndocu,
	c.email,c.nomcli,m.fecha,m.totn,m.mone,
	case @NombreProveedorFE
		when 'Nubefact' then m.serie
		when 'Telesoluciones' then m.TeleSol_Serie
		else m.serie
	end SerieFE,
	case @NombreProveedorFE
		when 'Nubefact' then m.numero
		when 'Telesoluciones' then m.TeleSol_Numero
		else m.serie
	end NumeroFE
	from 
	tbl_EnvioDocumentosElectronicos e
	inner join mst01fac m on e.cdocu=m.cdocu and e.ndocu=m.ndocu
	inner join mst01cli c on c.codcli=m.codcli
	where flag_enviado=0


	update tbl_EnvioDocumentosElectronicos set flag_enviado=1,FechaEnvio=getdate()
	where flag_enviado=0
end

