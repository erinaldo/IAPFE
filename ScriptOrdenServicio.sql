alter procedure USP_SEL_ORDENSERVICIO
(
	@fechai datetime,
	@fechaf datetime,
	@ndocu varchar(50),
	@nomcli varchar(250)
)
AS
begin
	if @ndocu =''
		set @ndocu=null
	if @nomcli=''
		set @nomcli=null;
	SELECT fecha,cdocu,ndocu,codcli,nomcli,ruccli,tcam,tota,toti,totn,flag,
	case flag when '0' then 'Nuevo' when '1' then 'Facturado' when '2' then 'Cerrado' end flagnombre
	FROM Mst_Orden_Servicio
	where fecha between cast(@fechai as DATE) and cast(@fechaf as date)
	and (@ndocu is null or ndocu like @ndocu + '%')
	and (@nomcli  is null or nomcli like @nomcli +'%')
	and flag='0'
end


ALTER procedure [dbo].[USP_UPD_ASIGNAR_CLIENTE_ORDENSERVICIO]
(
	@codcli varchar(15),
	@Ndocu varchar(12)
)
AS
BEGIN
	declare @nomcli varchar(250),@ruccli varchar(11)
	
	select @nomcli=nomcli,@ruccli=ruccli from mst01cli where codcli=@codcli
	
	update Mst_Orden_Servicio set codcli=@codcli,nomcli=@Nomcli,ruccli=@ruccli,flag='2',cFac='' where ndocu=@Ndocu
	update Dtl_Orden_Servicio set codcli=@codcli where ndocu=@Ndocu
	
END

alter procedure USP_SEL_CLIENTES_OS
AS
BEGIN
	select codcli,ltrim(rtrim(nomcli)) nomcli,ruccli from mst01cli
END