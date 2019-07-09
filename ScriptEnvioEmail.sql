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

