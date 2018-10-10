ALTER Procedure [dbo].[USP_Sel_ObtenerCabeceraDetalleFBNCND]
(
	@Cdocu char(2),
	@Ndocu varchar(12)
)
as
begin
	select fecha,cdocu,ndocu,crefe,nrefe,orde,f.codcli,RTRIM(LTRIM(f.nomcli)) nomcli,f.ruccli,
	RTRIM(LTRIM(c.dircli)) dircli,f.codcdv,
	cv.nomcdv CondicionVenta,f.fven,f.mone,f.tcam,f.tota,f.toti,f.totn,f.codven,
	v.nomven,f.flag
	from mst01fac f
	inner join mst01cli c on f.codcli=c.codcli 
	inner join tbl01cdv cv on cv.codcdv=f.Codcdv
	inner join tbl01ven v on v.codven=f.codven
	where cdocu=@Cdocu and ndocu=@Ndocu
	
	select cdocu,ndocu,item,codi,codf,ltrim(rtrim(marc)) marc,ltrim(rtrim(descr))descr,ltrim(rtrim(umed)) umed,cant,preu,tota,totn,mone
	from dtl01fac where cdocu=@Cdocu and ndocu=@Ndocu
end


ALTER PROCEDURE [dbo].[USP_Sel_ObtenerCabeceraDetalleGUIA]
(
	@CDOCU CHAR(2),
	@NDOCU VARCHAR(12)
)
AS
BEGIN
	select cast(fecha as DATE) fecha,cdocu,ndocu,G.codcli,
	ltrim(rtrim(cast(g.nomcli as varchar(150))))nomcli,g.ruccli,g.codGlo,c.Nomglo MotivoTraslado,
	g.codtra,ltrim(rtrim(cast(t.nomtra as varchar(150)))) transporte,
	t.teltra,ltrim(rtrim(t.dirtra)) direccionTransporte,t.ructra,
	g.drefe tipodocrefe,
	g.crefe,g.nrefe,g.mone,g.tcam,g.tota,g.toti,g.totn,g.codven,v.nombre vendedor,
	ltrim(rtrim(cast(g.dirpar as varchar(150)))) direccionpartida,
	ltrim(rtrim(cast(g.dirent as varchar(150)))) direccionentrega,g.marveh,
	ltrim(rtrim(cast(g.plaveh as varchar(30)))) plaveh,
	ltrim(rtrim(cast(g.nomcho as varchar(50)))) nomcho,
	ltrim(rtrim(cast(g.nrolic as varchar(50)))) nrolic,
	CASE month(g.fecha) 
		WHEN 1 THEN 'Enero'
		WHEN 2 THEN 'Febrero'
		WHEN 3 THEN 'Marzo'
		WHEN 4 THEN 'Abril'
		WHEN 5 THEN 'Mayo'
		WHEN 6 THEN 'Junio'
		WHEN 7 THEN 'Julio'
		WHEN 8 THEN 'Agosto'
		WHEN 9 THEN 'Setiembre'
		WHEN 10 THEN 'Octubre'
		WHEN 11 THEN 'Noviembre'
		WHEN 12 THEN 'Diciembre'
	end	Mes,
	YEAR(g.fecha) Anno,
	SUBSTRING(('0' + cast(DAY(g.fecha) as nvarchar(2))),1,2) Dia,
	case g.crefe
		when '01' then g.nrefe
		else ''
	end NroFactura,
	LEFT(cli.dircli,50) dircli
	
	from mst01gui g --where cdocu='09' and ndocu='001-00000001'
	left join tbl01tra t on g.codtra=t.codtra
	left join tbl01ven v on v.codven=g.codven
	left join tbl01gls c on c.codGlo=g.codglo
	left join mst01cli cli on g.codcli=cli.codcli
	WHERE G.cdocu=@CDOCU AND  G.ndocu=@NDOCU


	SELECT d.item,d.codf,d.codi,d.marc,d.descr,d.umed,d.cant FROM dtl01gui d
	WHERE cdocu=@CDOCU AND ndocu=@NDOCU


END


ALTER procedure [dbo].[USP_SEL_ParametroFormato]
as
begin
	select IDPARA,VALOR from TBL_PARAMETRO where IDPARA like 'Formato%'
end