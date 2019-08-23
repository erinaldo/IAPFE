alter table Mst_Orden_Servicio
add Cod_Operario varchar(5),FechaInicioServicio datetime,FechaFinServicio datetime

alter procedure USP_SEL_OperariosServicio
as
begin
	select codven Cod_Operario,nomven NombreOperario
	from tbl01ven
end



CREATE procedure [dbo].[USP_SEL_ORDENSERVICIO_OPERARIOS]
(
	@fechai datetime,
	@fechaf datetime,
	@ndocu varchar(50),
	@nomcli varchar(250),
	@flag char(1)
)
AS
begin
	if @ndocu =''
		set @ndocu=null
	if @nomcli=''
		set @nomcli=null;
	SELECT fecha,cdocu,ndocu,codcli,nomcli,ruccli,tcam,tota,toti,totn,flag,
	case flag when '0' then 'Nuevo' when '1' then 'Facturado' when '2' then 'Cerrado' end flagnombre,
	isnull(IdPedido,0) IdPedidoAndroid,DirEnt,CodUsuarioRegistro,
	flag_Estadopedido,
	case flag_Estadopedido 
		when 0 then 'Emitido'
		when 1 then 'Procesado'
		when 2 then 'Despachado'
		when 3 then 'Entregado'
	end EstadoPedido,
	Cod_Operario,
	FechaInicioServicio,
	FechaFinServicio
	FROM Mst_Orden_Servicio
	where fecha between cast(@fechai as DATE) and cast(@fechaf as date)
	and (@ndocu is null or ndocu like @ndocu + '%')
	and (@nomcli  is null or nomcli like @nomcli +'%')
	and flag=@flag
end


create table TipoServicios
(
	Id_TipoServicio int identity primary key,
	NombreServicio varchar(1500)
)

insert into TipoServicios  
(NombreServicio) values ('ACANALAMIENTO')

insert into TipoServicios  
(NombreServicio) values ('DOBLADA')


create procedure USP_SEL_TipoServicio
as
begin
	select Id_TipoServicio,NombreServicio from TipoServicios
end


alter table dtl_orden_servicio
add FechaInicioServicio datetime,
	FechaFinServicio datetime



ALTER procedure [dbo].[USP_SEL_ORDENSERVICIOLINEA]
(
	@ndocu varchar(12)
)
AS
begin
	select codf,codi,LTRIM(RTRIM(descr))descr,LTRIM(RTRIM(marc)) marc,
	umed,cant,preu,tota,totn
	,CodOte,FechaInicioServicio,FechaFinServicio
	 from Dtl_Orden_Servicio where ndocu=@ndocu
end