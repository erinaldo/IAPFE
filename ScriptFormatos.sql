ALTER Procedure [dbo].[USP_Sel_ObtenerCabeceraDetalleFBNCND]
(
	@Cdocu char(2),
	@Ndocu varchar(12)
)
as
begin
	select fecha,cdocu,ndocu,crefe,nrefe,orde,f.codcli,f.nomcli,f.ruccli,c.dircli,f.codcdv,
	cv.nomcdv CondicionVenta,f.fven,f.mone,f.tcam,f.tota,f.toti,f.totn,f.codven,
	v.nomven,f.flag
	from mst01fac f
	inner join mst01cli c on f.codcli=c.codcli 
	inner join tbl01cdv cv on cv.codcdv=f.Codcdv
	inner join tbl01ven v on v.codven=f.codven
	where cdocu=@Cdocu and ndocu=@Ndocu
	
	select cdocu,ndocu,item,codi,codf,marc,descr,umed,cant,preu,tota,totn,mone
	from dtl01fac where cdocu=@Cdocu and ndocu=@Ndocu
end


CREATE PROCEDURE USP_Sel_ObtenerCabeceraDetalleGUIA
(
	@CDOCU CHAR(2),
	@NDOCU VARCHAR(12)
)
AS
BEGIN
	select fecha,cdocu,ndocu,codcli,nomcli,ruccli,g.codGlo,c.Nomglo MotivoTraslado,
	g.codtra,t.nomtra transporte,
	t.teltra,t.dirtra direccionTransporte,t.ructra,
	g.drefe tipodocrefe,
	g.crefe,g.nrefe,g.mone,g.tcam,g.tota,g.toti,g.totn,g.codven,v.nombre vendedor,g.dirpar direccionpartida,
	g.dirent direccionentrega,g.marveh,g.plaveh,g.nomcho,g.nrolic
	from mst01gui g --where cdocu='09' and ndocu='001-00000001'
	left join tbl01tra t on g.codtra=t.codtra
	left join tbl01ven v on v.codven=g.codven
	left join tbl01gls c on c.codGlo=g.codglo
	WHERE G.cdocu=@CDOCU AND  G.ndocu=@NDOCU


	SELECT d.item,d.codf,d.codi,d.marc,d.descr,d.umed,d.cant FROM dtl01gui d
	WHERE cdocu=@CDOCU AND ndocu=@NDOCU

END


create procedure USP_SEL_ParametroFormato
as
begin
	select IDPARA,VALOR from TBL_PARAMETRO where IDPARA like 'Formato%'
	--FormatoFacturaElectronica
end