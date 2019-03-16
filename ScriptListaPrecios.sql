create procedure [dbo].[sp_ObtenerClaveVenta]
as
begin
	select fecha,clave,
	case flag
		when 0 then 1 else 0 end flag 
	from mst01clave
	order by fecha desc,case flag
		when 0 then 1 else 0 end DESC
end



create procedure [dbo].[sp_RegistrarClaveVenta]
(@clave char(12))
as
begin
	update mst01clave set flag=1 ;
	insert into mst01clave (fecha,clave,flag) values(cast(getdate() as date),RTRIM(@clave),0)
end



create procedure [dbo].[sp_listadoGrupos]
(@subfamilia varchar(max))
as
begin
	select codgru,rtrim(nomgru) nomgru from Tbl01Grp where codsub in
	(select LTRIM(RTRIM(item)) as Item from Fn_VS_Split(@subfamilia,', '))
end


ALTER procedure [dbo].[sp_ObtenerListadePrecios]
(
	@familia varchar(max),
	@subfamilia varchar(max),
	@grupo varchar(max),
	@moneda char(1),
	@costomayorcero int,
	@stockmayorcero int,
	@item varchar(250),
	@Descripcion varchar(250)
)
as
begin
	--declare @moneda char(1)='s'
	declare @igv float=0;
	declare @tipocambio float=0;
	declare @fechatipocambio datetime;
	
	--select i_g_v from psn0100
	select @igv=((i_g_v/100)+1) from psn0100
	select top 1 @tipocambio=tcvta from tbl01tca where year(getdate())=year(fecha) and tcvta<>0 order by fecha desc
	select top 1 @fechatipocambio=fecha from tbl01tca where year(getdate())=year(fecha) and tcvta<>0 order by fecha desc
	
	if(@costomayorcero=0)
		set @costomayorcero=null;
	if(@item='')
		set @item=null;
	if(@stockmayorcero=0)
		set @stockmayorcero=null;
	if(ltrim(rtrim(@Descripcion))='')
		set @Descripcion=null
	
	if(@item is null)
	begin
		select --f.nomfam Familia,s.nomsub SubFamilia,g.nomgru,
		p.codi CodigoSistema,p.codf CodigoEmpresa,RTRIM(P.marc) Marca,RTRIM(p.descr) Descripcion,p.umed UnidadMedida,
		(scon+stoc)-(svta + pedi) As StockDisponible,
		
		case 
			when p.pcns=0 then
				ISNULL(ROUND((
					select top 1
						case when mone='s' then preu else preu*tcam end
					from kdd0101 kdd where kdd.codi =p.codi--'0101-010016' 
					and tmov='e'
					order by fecha desc,IDENTY DESC
				),4),0)
			else
				p.pcns 
		end UltCostoCompraSoles,
		case 
			when p.pcus=0 then
				ISNULL(ROUND((
					select top 1
						case when mone='D' then preu else preu/tcam end
					from kdd0101 kdd where kdd.codi =p.codi--'0101-010016' 
					and tmov='e'
					order by fecha desc,IDENTY DESC
				),4),0)
			else
				p.pcus
		end UltCostoCompraDolar,
		--(isnull((case when l.Moneda='S' then l.ValorVenta else l.ValorVenta*@tipocambio end),0)) PrecioVentaSoles,
		--(isnull((case when l.Moneda='D' then l.ValorVenta else l.ValorVenta/@tipocambio end),0)) PrecioVentaDolar,
		(isnull((case when l.Moneda='S' then l.ValorVenta else l.ValorVenta*@tipocambio end),0)) PrecioVentaSoles,
		(isnull((case when l.Moneda='D' then l.ValorVenta else l.ValorVenta/@tipocambio end),0)) PrecioVentaDolar,
		isnull(l.PorcentajeAumento,0.00)  as ValorVentaIngreso,
		l.FechaValorVenta,
		@tipocambio tcventa,
		@fechatipocambio fechatc,
		p.mone as MonedaArticulo
		from 
		prd0101  p --on --d.codi=p.codi 	
		left Join Tbl01Grp g on SubString(p.codi,1,2)+'-'+SubString(p.codi,3,2)+'-'+SubString(p.codi,6,2)=g.codgru 	
		left Join Tbl01Sbf s on SubString(p.codi,1,2)+'-'+SubString(p.codi,3,2)=s.codsub 	
		left Join Tbl01Fam f on SubString(p.codi,1,2)=f.codfam
		left join ListaPrecios l on l.codi=p.codi
		where --p.codf='100350/1168-1  ' and 
		--case when f.codfam<> '07' then ((scon+stoc)-(svta + pedi))<>0 else
		--and f.codfam<>'07'
		--and 
		F.CODFAM in (select LTRIM(RTRIM(item)) as Item from Fn_VS_Split(@familia,', '))
		and s.codsub in (select LTRIM(RTRIM(item)) as Item from Fn_VS_Split(@subfamilia,', '))
		and g.codgru in (select LTRIM(RTRIM(item)) as Item from Fn_VS_Split(@grupo,', '))
		and p.codi<>'0000-000000' 
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
		--or (@item is null or p.codf like '%'+@item+'%')
		order by (scon+stoc)-(svta + pedi) desc
	end
	else
	begin
	
		select --f.nomfam Familia,s.nomsub SubFamilia,g.nomgru,
		p.codi CodigoSistema,p.codf CodigoEmpresa,RTRIM(P.marc) Marca,RTRIM(p.descr) Descripcion,p.umed UnidadMedida,
		(scon+stoc)-(svta + pedi) As StockDisponible,
		case 
			when p.pcns=0 then
				ISNULL(ROUND((
					select top 1
						case when mone='s' then preu else preu*tcam end
					from kdd0101 kdd where kdd.codi =p.codi--'0101-010016' 
					and tmov='e'
					order by fecha desc,IDENTY DESC
				),4),0)
			else
				p.pcns 
		end UltCostoCompraSoles,
		case 
			when p.pcus=0 then
				ISNULL(ROUND((
					select top 1
						case when mone='D' then preu else preu/tcam end
					from kdd0101 kdd where kdd.codi =p.codi--'0101-010016' 
					and tmov='e'
					order by fecha desc,IDENTY DESC
				),4),0)
			else
				p.pcus
		end UltCostoCompraDolar,
		
		(isnull((case when l.Moneda='S' then l.ValorVenta else l.ValorVenta*@tipocambio end),0)) PrecioVentaSoles,
		(isnull((case when l.Moneda='D' then l.ValorVenta else l.ValorVenta/@tipocambio end),0)) PrecioVentaDolar,
		isnull(l.PorcentajeAumento,0.00)  as ValorVentaIngreso,
		l.FechaValorVenta,
		@tipocambio tcventa,
		@fechatipocambio fechatc,
		p.mone as MonedaArticulo
		from 
		prd0101  p --on --d.codi=p.codi 	
		left Join Tbl01Grp g on SubString(p.codi,1,2)+'-'+SubString(p.codi,3,2)+'-'+SubString(p.codi,6,2)=g.codgru 	
		left Join Tbl01Sbf s on SubString(p.codi,1,2)+'-'+SubString(p.codi,3,2)=s.codsub 	
		left Join Tbl01Fam f on SubString(p.codi,1,2)=f.codfam
		left join ListaPrecios l on l.codi=p.codi
		where 
		p.codf like '%'+@item+'%'
		and (@Descripcion is null or p.descr like '%'+@Descripcion+'%')
		order by (scon+stoc)-(svta + pedi) desc
	end
end




CREATE TABLE [dbo].[ListaPrecios](
	[codi] [varchar](12) NULL,
	[Moneda] [char](1) NULL,
	[CostoCompra] [float] NULL,
	[ValorVenta] [float] NULL,
	[FechaValorVenta] [datetime] NULL
) ON [PRIMARY]

GO



USE [bdNava01]
GO
/****** Object:  StoredProcedure [dbo].[sp_RegistrarListadePrecios]    Script Date: 01/29/2019 09:13:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[sp_RegistrarListadePrecios]
(
	@CodLis	char(2),
	@Codi	char(11),
	@vventa	decimal(12,4),
	@crepus	decimal(12,4),
	@creps  decimal(12,4),
	@codf	char(15),
	@descr	varchar(80),
	@mone	char(1),
	@marca	varchar(20),
	@umed	char(3),
	@tcam	decimal(12,4)
)
as
begin
	declare @igv float;
	--select i_g_v from psn0100
	select @igv=((i_g_v/100)+1) from psn0100
	
	-------------------------------
	DECLARE @vventaD decimal(12,4),@vventaS decimal(12,4)
	--50
	--100-10=90/100=50/0.9
	SET @vventaD=round((@crepus/((100-@vventa)/100)),4)
	set @vventaS=round((@creps/((100-@vventa)/100)),4)
	--SET @vventaD=round((@crepus/((@vventa/10))),4)
	--set @vventaS=round((@creps/((@vventa/10))),4)
	-------------------------------
	--select * from dtl01pre where codi='0101-020001'
	if exists(select * from dtl01pre where codi=@codi)
	begin
		--if(@mone='S')
	    
		UPDATE dtl01pre SET 
		--vvns=ROUND((case when @mone='s' then @vventa else @vventa*@tcam end),2),
		--pvns=ROUND((case when @mone='s' then @vventa else @vventa*@tcam end)*@igv,2),
		--vvus=ROUND((case when @mone='D' then @vventa else @vventa/@tcam end),2),
		--pvus=ROUND((case when @mone='D' then @vventa else @vventa/@tcam end)*@igv,2),
		vvns=ROUND((@vventaS/@igv),2),
		pvns=@vventaS,
		vvus=ROUND((@vventaD*@igv),2),
		pvus=@vventaD,
		porc_tar=0,
		imptarns=@vventaS,
		imptarus=@vventaD,
		cpu=ROUND((case when @mone='D' then @crepus else @creps end),4),
		crep=ROUND((case when @mone='D' then @crepus else @creps end),4),
		margen_min=0,
		minus=@crepus,--ROUND((case when @mone='D' then @crep else @crep/@tcam end),2), --(case when @mone='D' then @vventa else @vventa/@tcam end)*@igv*1.08,
		minns=@creps,--ROUND((case when @mone='S' then @crep else @crep*@tcam end),2),--(case when @mone='s' then @vventa else @vventa*@tcam end)*@igv*1.08,
		codf=@codf,
		descr=@descr,
		mone=@mone,
		marca=@marca,umed=@umed,tcam=@tcam,f_proceso=getdate(),Observacion='',
		margen_max=20 where Codi=@Codi;
		
		
	end
	else
	begin
		--DECLARE @LISTA CHAR(2)
		DECLARE @IDLISTA INT=1
		while @IDLISTA<=7
		BEGIN
			IF(@IDLISTA IN(1,3,4,7))
			BEGIN
				SET @CodLis='0'+CAST(@IDLISTA AS VARCHAR)

				INSERT INTO dtl01pre (CodLis,Codi,
				vvns,pvns,vvus,pvus,
				porc_tar,
				imptarns,imptarus,cpu,crep,margen_min,minus,minns,
				codf,descr,mone,marca,umed,tcam,f_proceso,Observacion,margen_max)
				VALUES(@CodLis,@Codi,
				--ROUND((case when @mone='s' then @vventa else @vventa*@tcam end),2),
				--ROUND((case when @mone='s' then @vventa else @vventa*@tcam end)*@igv,2),
				--ROUND((case when @mone='D' then @vventa else @vventa/@tcam end),2),
				--ROUND((case when @mone='D' then @vventa else @vventa/@tcam end)*@igv,2),
				@vventaS,ROUND((@vventaS*@igv),2),@vventaD,ROUND((@vventaD*@igv),4),
				0,
				--ROUND((case when @mone='s' then @vventa else @vventa*@tcam end)*@igv,2),
				--ROUND((case when @mone='D' then @vventa else @vventa/@tcam end)*@igv,2),
				--ROUND((case when @mone='D' then @crepus else @creps end),2),
				--ROUND((case when @mone='D' then @crepus else @creps end),2),
				ROUND((@vventaS*@igv),4),ROUND((@vventaD*@igv),4),ROUND((case when @mone='D' then @crepus else @creps end),4),
				ROUND((case when @mone='D' then @crepus else @creps end),4),
				0,

				@crepus,
				@creps,
				@codf,
				@descr,
				@mone,
				@marca,@umed,@tcam,getdate(),'',
				20 )
			END
			SET @IDLISTA=@IDLISTA+1;
		END
	end
	
	
	if exists(select 1 from ListaPrecios where codi=@Codi)
	begin
		update ListaPrecios set Moneda=@mone,
		CostoCompra=ROUND((case when @mone='D' then @crepus else @creps end),4),
		ValorVenta=ROUND((case when @mone='D' then @vventaD else @vventaS end),4),
		FechaValorVenta=GETDATE(),
		PorcentajeAumento=@vventa
		where codi=@Codi;
	end
	else
	begin
		insert into ListaPrecios (codi,Moneda,CostoCompra,ValorVenta,FechaValorVenta,PorcentajeAumento)
		values
		(@Codi,@mone,
		ROUND((case when @mone='D' then @crepus else @creps end),4),
		ROUND((case when @mone='D' then @vventaD else @vventaS end),4),
		GETDATE(),@vventa)
	end
	--REGISTRO DEL PRECIO EN EL ARTICULO
	UPDATE prd0101 SET 
	pvns=round((@vventaS),4),
	pvus=round((@vventaD),4)
	WHERE codi=@CODI
end
