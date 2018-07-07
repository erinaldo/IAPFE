create table UsuarioIntranet
(
	Id int identity primary key not null,
	Nombres	varchar(50),
	Apellidos varchar(50),
	RazonSocial	varchar(150),
	Correo	varchar(50),
	Contrasena varchar(100),
	FechaRegistro datetime
)

create procedure ObtenerUsuarioIntranet
(	@Nombres varchar(50))
as
begin
	select Id,Nombres,Apellidos,RazonSocial,Correo,Contrasena, FechaRegistro
	from UsuarioIntranet where Nombres like @Nombres + '%'
end

alter procedure ObtenerUsuario
(
	@correo varchar(250),
	@contrasena varchar(250)
)
as
begin

	if exists(
	select 1 from UsuarioIntranet where correo=@correo and contrasena=@contrasena)
	begin
		select 1 as Estado
	end
	else
	begin
		select 1 as Estado
	end
end