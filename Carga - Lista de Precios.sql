--PRIMERO SE DEBE CREAR EL LINK DEL SERVIDOR
--[sql7002.site4now.net].DB_A442E2_grupoiap2018.dbo.prd0101

CREATE procedure [dbo].[Usp_INS_ListaPreciosAndroid]
as
begin
	declare 
	@familia varchar(max)='',
	@subfamilia varchar(max)='',
	@grupo varchar(max)='',
	@moneda char(1)='S',
	@costomayorcero int=0,
	@stockmayorcero int=1,
	@item varchar(250)='',
	@Descripcion varchar(250)='',
	@Ruc varchar(11)=''

	select @Ruc=RucEmpresa from DatosEmpresa

	if(isnull(@Ruc,'')='')
	begin
		raiserror('La base de datos no tiene definida el parametro RUC en DatosEmpresa',16,1)
		return;
	end


	--declare @moneda char(1)='s'
	declare @igv float=0;
	declare @tipocambio float=0;
	declare @fechatipocambio datetime;
	
	--select i_g_v from psn0100
	select @igv=((i_g_v/100)+1) from psn0100
	select top 1 @tipocambio=tcvta from tbl01tca where year(getdate())=year(fecha) and tcvta<>0 order by fecha desc
	select top 1 @fechatipocambio=fecha from tbl01tca where year(getdate())=year(fecha) and tcvta<>0 order by fecha desc
	
	if(@familia='')
		set @familia=null;
	if(@subfamilia='')
		set @subfamilia=null;
	if(@grupo='')
		set @grupo=null;
	if(@costomayorcero=0)
		set @costomayorcero=null;
	if(@item='')
		set @item=null;
	if(@stockmayorcero=0)
		set @stockmayorcero=null;
	if(ltrim(rtrim(@Descripcion))='')
		set @Descripcion=null
	--select * from [sql7002.site4now.net].DB_A442E2_grupoiap2018.dbo.prd0101
	DELETE FROM [sql7002.site4now.net].DB_A442E2_grupoiap2018.dbo.prd0101;

	insert into [sql7002.site4now.net].DB_A442E2_grupoiap2018.dbo.prd0101 
	(codi,codf,descripcion,marca,codalm,stoc,UnidadMedida,Precio,FechaCreacion,Bloqueado,Moneda,Ruc)
	

		select 
		p.codi 
		,p.codf,
		RTRIM(p.descr) Descripcion,
		RTRIM(P.marc) Marca,
		'01',
		(P.scon+P.stoc)-(svta + pedi) As StockDisponible,
		p.umed UnidadMedida,
		round(((isnull((case when l.Moneda='S' then l.ValorVenta else l.ValorVenta*@tipocambio end),0))),4) PrecioVentaSoles,
		GETDATE(),
		0,--bloqueado
		p.mone as MonedaArticulo,
		@ruc
		--round((@igv*(case 
		--	when p.pcns=0 then
		--		ISNULL(ROUND((
		--			select top 1
		--				case when mone='s' then preu else preu*tcam end
		--			from kdd0101 kdd where kdd.codi =p.codi--'0101-010016' 
		--			and tmov='e'
		--			order by fecha desc,IDENTY DESC
		--		),4),0)
		--	else
		--		p.pcns
		--end)),4) UltCostoCompraSoles,
		--round((@igv*(case 
		--	when p.pcus=0 then
		--		ISNULL(ROUND((
		--			select top 1
		--				case when mone='D' then preu else preu/tcam end
		--			from kdd0101 kdd where kdd.codi =p.codi--'0101-010016' 
		--			and tmov='e'
		--			order by fecha desc,IDENTY DESC
		--		),4),0)
		--	else
		--		p.pcus
		--end)),4) UltCostoCompraDolar,
		
		
		--round(((isnull((case when l.Moneda='D' then l.ValorVenta else l.ValorVenta/@tipocambio end),0))),4) PrecioVentaDolar,
		--isnull(l.PorcentajeAumento,0.00)  as ValorVentaIngreso,
		--l.FechaValorVenta,
		--@tipocambio tcventa,
		--@fechatipocambio fechatc,
		
		from 
		prd0101  p --on --d.codi=p.codi 	
		left Join Tbl01Grp g on SubString(p.codi,1,2)+'-'+SubString(p.codi,3,2)+'-'+SubString(p.codi,6,2)=g.codgru 	
		left Join Tbl01Sbf s on SubString(p.codi,1,2)+'-'+SubString(p.codi,3,2)=s.codsub 	
		left Join Tbl01Fam f on SubString(p.codi,1,2)=f.codfam
		left join ListaPrecios l on l.codi=p.codi
		where 
		(@familia is null or( F.CODFAM in (select LTRIM(RTRIM(item)) as Item from Fn_VS_Split(@familia,', '))))
		and (@subfamilia is null or ( s.codsub in (select LTRIM(RTRIM(item)) as Item from Fn_VS_Split(@subfamilia,', '))))
		and (@grupo is null or ( g.codgru in (select LTRIM(RTRIM(item)) as Item from Fn_VS_Split(@grupo,', '))))
		and p.codi<>'0000-000000' 
		--and p.codf='10012'
		and (@Descripcion is null or p.descr like '%'+@Descripcion+'%')
		and (@costomayorcero is null or ISNULL(ROUND((
			select top 1
			case 
				when @moneda='s' 
					then case when mone='s' then preu else preu/tcam end
				when @moneda='D'
					then case when mone='d' then preu else preu*tcam end
			end
			from kdd0101 kdd where kdd.codi =p.codi--'0101-010016' 
			and tmov='e'
			order by fecha desc,IDENTY DESC
		),4),0)>0)
		and (@stockmayorcero is null or ((scon+stoc)-(svta + pedi))>0)
		order by (scon+stoc)-(svta + pedi) desc

end

