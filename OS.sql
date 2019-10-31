ALTER procedure [dbo].[USP_SEL_ORDENSERVICIOLINEA]
(
	@ndocu varchar(12)
)
AS
begin
	select codf,codi,LTRIM(RTRIM(descr))descr,LTRIM(RTRIM(marc)) marc,
	umed,cant,preu,tota,totn
	,CodOte,FechaInicioServicio,FechaFinServicio,ndocu,item
	 from Dtl_Orden_Servicio where ndocu=@ndocu
end

go


ALTER procedure [dbo].[USP_INS_RegistrarOS_Android_ERP]
(

@fecha date,@codcli varchar(25),@nomcli varchar(500),@ruccli varchar(50),@codcdv varchar(10),@tcam money,@tota money,@toti money,
@totn money,@IdPedido int,@DirEnt varchar(500),@CodUsuarioregistro varchar(50)
)
as
begin
	declare @ndocu varchar(50)='',@Numero int=0,@Serie varchar(10)

	select @ndocu=nroini from tbl01cor where cdocu='76'

	IF LEN(@RUCCLI)=11
	BEGIN
		if not exists(select * from mst01cli where ruccli=@ruccli)
		begin
			begin try
				exec USP_INS_CLIENTESUNAT_ANDROID @ruccli,@nomcli,@DirEnt
				select @codcli=codcli from mst01cli where ruccli=@ruccli
			end try
			begin catch
				raiserror('ERROR AL REGISTRAR EL CLIENTE EN EL ERP',16,1);
				RETURN;
			end catch
		end
	END
	ELSE
	BEGIN
		if not exists(select * from mst01cli where nrodni=@ruccli)
		begin
			begin try
				exec USP_INS_CLIENTESUNAT_ANDROID @ruccli,@nomcli,@DirEnt
				select @codcli=codcli from mst01cli where nrodni=@ruccli
			end try
			begin catch
				raiserror('ERROR AL REGISTRAR EL CLIENTE EN EL ERP',16,1);
				RETURN;
			end catch
		end
	END
	

	
	set @Numero=cast(right(@ndocu,8) as int)
	set @Serie=left(@ndocu,3)
	
	set @ndocu=@Serie+'-'+right(('00000000'+cast((@Numero+1) as varchar(8))),8)
	
	insert into  Mst_Orden_Servicio (
	fecha
	,cdocu
	,ndocu
	,drefe
	,crefe
	,nrefe
	,codcli
	,nomcli
	,ruccli
	,codcdv
	,mone
	,tcam
	,tota
	,toti
	,totn
	,codven
	,codalm
	,codpto
	,flag
	,cdge
	,ndge
	,orde
	,cFac
	,nFac
	,MotAnu
	,codglo
	,idalias
	,codser
	,FecReg
	,placacar
	,modcar
	,marcar
	,añocar
	,kilcar
	,codvta
	,codscc
	,lugfac
	,forpagvta
	,flagcom
	,flg_arqueado
	,FechaArqueo
	,UsuarioArqueo
	,Cancelado
	,IdPedido
	,DirEnt
	,CodUsuarioRegistro
	,flag_Estadopedido
	) values(
	@fecha,'76',@ndocu,'N','','',@codcli,@nomcli,@ruccli,@codcdv,'S',@tcam,@tota,@toti,@totn,
	'V0000','01','01','0','','','','','','','01',0,'01',GETDATE(),'','','','2019',0,'02','0101950103','001','E',0,null,null,null,null,
	@IdPedido,@DirEnt,@CodUsuarioregistro,0)

	update tbl01cor set nroini=@ndocu where cdocu='76'

	select @ndocu
	--select * from Mst_Orden_Servicio order by ndocu desc
end

go


ALTER PROCEDURE [dbo].[USP_INS_CLIENTESUNAT_ANDROID]
(
	@RUC VARCHAR(11),
	@NOMBRECOMERCIAL VARCHAR(250),
	@DIRECCION VARCHAR(500)
)
AS
BEGIN
	--select * from mst01cli
	DECLARE @CODIGOCLIENTE VARCHAR(10)
	DECLARE @NRODNI VARCHAR(11)
	SELECT @CODIGOCLIENTE='C' + RIGHT(('00000' + CAST((CAST(RIGHT(codcli,5)AS INT) +1 ) AS VARCHAR(15))),5) FROM psn0100
	SET @NRODNI=@RUC
	IF LEN(@RUC)=8
	BEGIN
		SET @RUC='DNI'+@RUC
	END
	
	
	
INSERT INTO MST01CLI (CODCLI,NOMCLI,DIRCLI,RUCCLI,NRODNI,FLAPER,DIRENT,TELCLI,FAXCLI,CODPOS,CODDIS,CODPRO,
CODDEP,CODPAI,CODZON,CODVEN,VENSUP,CODCOB,CODACT,CODCDV,FECING,FLALIN,MCREDI,
FECAPR,DSCTXV,DSCTCR,TIPOCL,DIAPAG,HRSPAG,FICHA,NOMCAJ,TELCAJ,CODGRP,EMAIL,
ESTADO,NOMAVA,DIRAVA,RUCAVA,TELAVA,CAPDEC,FLALOC,NOMBCO1,NROCTA1,NOMSEC1,TELSEC1,
NOMBCO2,NROCTA2,NOMSEC2,TELSEC2,NOMREF1,MONREF1,CONREF1,NOMREF2,MONREF2,CONREF2,
NOMREF3,MONREF3,CONREF3,CODCAT,FECPAG,HORPAG,TIPFAX,VISCLI,CTLPER,CATSNT,PEROBL,
CODLIS,IDNUCLEO,ARSNT,CODMONLINEA,MAMPCRE,FLADESPER,CODCIIU,FLACENRIE,TASCENRIE,
CODEST,STATUSLEGAL,FECSTATUS,CODSCCMER,CODSCCREE,CODDOCIDE,FECANI,DEFGASFIN,CELCLI,
DIRCOB,CODGRU_EMPRE,CUOTA_VENTA,CODTIPO,VENLUB,VENOTRO,FLADV,FLADVCON,FLADVCRE,
FECAPRDV,DVTIPOA,DVTIPOB,DVTIPOC,DVNUMDIAS1,DVNUMDIAS2,CODANA,CODSACT,FECNAC) 
VALUES (

@CODIGOCLIENTE,@NOMBRECOMERCIAL,
@DIRECCION,
@RUC,--ruccli
@NRODNI,--nrodni
2, -- NATURAL  - JURIDICO
@DIRECCION,
'',--telcli
'',--faxcli
'01',
'','','',
'01','01',
'V0000',--codven
'V0000',--vensup
'V0000',--codcob
'01',
'01',
cast(GETDATE() as DATE),
1,0,'',0,0,'B','','','','','',
'','',1,'','','',
'',0,1,'','','','','','','','','',0,'',
'',0,'','',0,'','01',0,'',1,'',0,0,0,'',0,0,
'',0,0,'',0,0,'',0,'','','','05','','F','',
'',0,0,'01','V0000','V0000',0,0,0,'',0,0,0,0,0,'','',
'')

UPDATE psn0100 SET codcli=@CODIGOCLIENTE
END


go


ALTER PROCEDURE [dbo].[USP_INS_CLIENTESUNAT]
(
	@RUC VARCHAR(11),
	@NOMBRECOMERCIAL VARCHAR(250),
	@FECHACREACION DATETIME,
	@ESTADO VARCHAR(100),
	@CONDICION VARCHAR(100),
	@DIRECCION VARCHAR(500)
)
AS
BEGIN
	--select * from mst01cli
	DECLARE @CODIGOCLIENTE VARCHAR(10)
	SELECT @CODIGOCLIENTE='C' + RIGHT(('00000' + CAST((CAST(RIGHT(codcli,5)AS INT) +1 ) AS VARCHAR(15))),5) FROM psn0100
	
INSERT INTO MST01CLI (CODCLI,NOMCLI,DIRCLI,RUCCLI,NRODNI,FLAPER,DIRENT,TELCLI,FAXCLI,CODPOS,CODDIS,CODPRO,
CODDEP,CODPAI,CODZON,CODVEN,VENSUP,CODCOB,CODACT,CODCDV,FECING,FLALIN,MCREDI,
FECAPR,DSCTXV,DSCTCR,TIPOCL,DIAPAG,HRSPAG,FICHA,NOMCAJ,TELCAJ,CODGRP,EMAIL,
ESTADO,NOMAVA,DIRAVA,RUCAVA,TELAVA,CAPDEC,FLALOC,NOMBCO1,NROCTA1,NOMSEC1,TELSEC1,
NOMBCO2,NROCTA2,NOMSEC2,TELSEC2,NOMREF1,MONREF1,CONREF1,NOMREF2,MONREF2,CONREF2,
NOMREF3,MONREF3,CONREF3,CODCAT,FECPAG,HORPAG,TIPFAX,VISCLI,CTLPER,CATSNT,PEROBL,
CODLIS,IDNUCLEO,ARSNT,CODMONLINEA,MAMPCRE,FLADESPER,CODCIIU,FLACENRIE,TASCENRIE,
CODEST,STATUSLEGAL,FECSTATUS,CODSCCMER,CODSCCREE,CODDOCIDE,FECANI,DEFGASFIN,CELCLI,
DIRCOB,CODGRU_EMPRE,CUOTA_VENTA,CODTIPO,VENLUB,VENOTRO,FLADV,FLADVCON,FLADVCRE,
FECAPRDV,DVTIPOA,DVTIPOB,DVTIPOC,DVNUMDIAS1,DVNUMDIAS2,CODANA,CODSACT,FECNAC) 
VALUES (

@CODIGOCLIENTE,@NOMBRECOMERCIAL,
@DIRECCION,
@RUC,--ruccli
@RUC,--nrodni
2, -- NATURAL  - JURIDICO
@DIRECCION,
'',--telcli
'',--faxcli
'01',
'','','',
'01','01',
'V0000',--codven
'V0000',--vensup
'V0000',--codcob
'01',
'01',
cast(GETDATE() as DATE),
1,0,'',0,0,'B','','','','','',
'','',1,'','','',
'',0,1,'','','','','','','','','',0,'',
'',0,'','',0,'','01',0,'',1,'',0,0,0,'',0,0,
'',0,0,'',0,0,'',0,'','','','05','','F','',
'',0,0,'01','V0000','V0000',0,0,0,'',0,0,0,0,0,'','',
'')

UPDATE psn0100 SET codcli=@CODIGOCLIENTE
END


go


ALTER procedure [dbo].[USP_SEL_OperariosServicio]
as
begin
	select codven Cod_Operario,nomven NombreOperario
	from tbl01ven
end

go

ALTER procedure [dbo].[USP_SEL_TipoServicio]
as
begin
	select Id_TipoServicio,NombreServicio from TipoServicios
end

go


ALTER procedure [dbo].[USP_SEL_ORDENSERVICIO_OPERARIOS]
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


go


ALTER procedure [dbo].[Usp_INS_ListaPreciosAndroid]
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



go



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
	
	if(@item is null)
	begin
		select 
		p.codi CodigoSistema,p.codf CodigoEmpresa,RTRIM(P.marc) Marca,RTRIM(p.descr) Descripcion,p.umed UnidadMedida,
		(scon+stoc)-(svta + pedi) As StockDisponible,
		
		round((@igv*(case 
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
		end)),4) UltCostoCompraSoles,
		round((@igv*(case 
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
		end)),4) UltCostoCompraDolar,
		--(isnull((case when l.Moneda='S' then l.ValorVenta else l.ValorVenta*@tipocambio end),0)) PrecioVentaSoles,
		--(isnull((case when l.Moneda='D' then l.ValorVenta else l.ValorVenta/@tipocambio end),0)) PrecioVentaDolar,
		round(((isnull((case when l.Moneda='S' then l.ValorVenta else l.ValorVenta*@tipocambio end),0))),4) PrecioVentaSoles,
		round(((isnull((case when l.Moneda='D' then l.ValorVenta else l.ValorVenta/@tipocambio end),0))),4) PrecioVentaDolar,
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
		(@familia is null or( F.CODFAM in (select LTRIM(RTRIM(item)) as Item from Fn_VS_Split(@familia,', '))))
		and (@subfamilia is null or ( s.codsub in (select LTRIM(RTRIM(item)) as Item from Fn_VS_Split(@subfamilia,', '))))
		and (@grupo is null or ( g.codgru in (select LTRIM(RTRIM(item)) as Item from Fn_VS_Split(@grupo,', '))))
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

		order by (scon+stoc)-(svta + pedi) desc
	end
	else
	begin
	
		select --f.nomfam Familia,s.nomsub SubFamilia,g.nomgru,
		p.codi CodigoSistema,p.codf CodigoEmpresa,RTRIM(P.marc) Marca,RTRIM(p.descr) Descripcion,p.umed UnidadMedida,
		(scon+stoc)-(svta + pedi) As StockDisponible,
		round((@igv*(case 
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
		end)),4) UltCostoCompraSoles,
		round((@igv*(case 
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
		end)),4) UltCostoCompraDolar,
		
		round(((isnull((case when l.Moneda='S' then l.ValorVenta else l.ValorVenta*@tipocambio end),0))),4) PrecioVentaSoles,
		round(((isnull((case when l.Moneda='D' then l.ValorVenta else l.ValorVenta/@tipocambio end),0))),4) PrecioVentaDolar,
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



go


ALTER procedure [dbo].[usp_udp_ActualizarFlagEstadosPedidoManual]
(@IdPedido numeric(18,0),@flagEstado int,@ruc varchar(11))
as
begin
	declare @flag_estadopedidoActual int,@flagActual char(1)
	select @flag_estadopedidoActual=flag_estadoPedido from Mst_Orden_Servicio where IdPedido=@IdPedido

	if(@flagActual='*')
	begin
		raiserror('El pedido actual se encuentra anulado, imposible realizar cambios.',16,1);
		return;
	end

	update Mst_Orden_Servicio set flag_estadoPedido=@flagEstado where IdPedido=@IdPedido
end

go



ALTER procedure [dbo].[usp_udp_ActualizarFlagEstadosPedido]
(@IdPedido numeric(18,0),@ruc varchar(11))
as
begin
	/*
	0=Emitido
	1=Procesando y Validando
	2=Despachado
	3=Entregado
	*/
	
	declare @flag_estadopedidoActual int,@flagActual char(1)
	select @flag_estadopedidoActual=flag_estadoPedido from Mst_Orden_Servicio where IdPedido=@IdPedido

	if(@flagActual='*')
	begin
		raiserror('El pedido actual se encuentra anulado, imposible realizar cambios.',16,1);
		return;
	end
	if(@flag_estadopedidoActual=3)
	begin
		raiserror('El pedido ya se encuentra en estado Entregado, imposible realizar cambios',16,1)
		return;
	end

	update Mst_Orden_Servicio set flag_estadoPedido=flag_estadoPedido+1 where IdPedido=@IdPedido

end


go


ALTER procedure [dbo].[USP_INS_RegistrarOS_Linea_Android_ERP]
(
@ndocu varchar(12),@codf varchar(15),@codi varchar(11),@cant float,@preu float,@tota float,@totn float
)
as
begin
declare @fecha date,@codcli varchar(6),@item int,@umed varchar(3),@desc varchar(80),@marc varchar(5),@tcam money,@msto char(1),@moneitm char(1)

	select @umed=ltrim(rtrim(umed)),@desc=ltrim(rtrim(descr)),@marc=ltrim(rtrim(marc)),@moneitm=ltrim(rtrim(mone)),@msto=ltrim(rtrim(msto)) 
	from prd0101 where codi=@codi
	--select * from Dtl_Orden_Servicio where codi='0701-020001'
	--select mone, * from prd0101 where codi='0701-020001'

	select @fecha=fecha,@codcli=ltrim(rtrim(codcli)),@tcam=tcam from Mst_Orden_Servicio where ndocu=@ndocu
	select @item=isnull((COUNT(*)+1),0) from Dtl_Orden_Servicio where ndocu=@ndocu

	
	insert into Dtl_Orden_Servicio 
	(cdocu	,ndocu	,fecha	,codcli	,item	,codf	,codi	,marc	,descr	,umed	,cant	,cdes	,cost	,preu	,dsct	,dsct2	,dsct3
	,tota	,totn	,mone	,moneitm	,tcam	,codalm	,aigv	,flag	,codpos	,msto	,uvta	,umedu	,ucon	,ucom	,CodOte	,itmsergra
	,codscc
	,IDProm
) values
('76',@ndocu,@fecha,@codcli,@item,@codf,@codi,isnull(@marc,''),isnull(@desc,''),isnull(@umed,''),
round(cast(@cant as money),3),0,0,
round(cast(@preu as money),3),0,0,0,
round(cast(@tota as money),3),
round(cast(@totn as money),3),

'S',@moneitm,@tcam,'01','S','0','',@msto,1,'',1,'','','N','0101950103',0)
	--select * from Dtl_Orden_Servicio
end

go



ALTER procedure [dbo].[USP_Del_EliminarOS_Android_ERP]
(
	@ndocu varchar(25)
)
as
begin
	delete from Dtl_Orden_Servicio where ndocu=@ndocu
	delete from Mst_Orden_Servicio where ndocu=@ndocu
end

go


ALTER procedure [dbo].[USP_SEL_ORDENSERVICIO]
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
	end EstadoPedido
	FROM Mst_Orden_Servicio
	where fecha between cast(@fechai as DATE) and cast(@fechaf as date)
	and (@ndocu is null or ndocu like @ndocu + '%')
	and (@nomcli  is null or nomcli like @nomcli +'%')
	and flag=@flag
end

go



ALTER PROCEDURE [dbo].[USP_SEL_ObtenerDocumentosPendientes_EnvioFE]
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


go



ALTER PROCEDURE [dbo].[SP_VS_CDN_DASHBOARD]
@FECHAI DATETIME,
@FECHAF DATETIME

AS
begin
SELECT 
	tie.nomtie as Tienda,Sc.nomscc as SubCC,
	m.codscc,m.codven Codigo_Vendedor,v.nomven Vendedor,v.codsccmer,v.codsccree,
 	CONVERT (char(10), m.fecha, 103) As Fecha_Documento,CONVERT (char(10), m.fven, 103) As Fecha_Vencimiento,
 	m.cdocu as Codigo_Documento,m.ndocu as Numero_Documento,
	cv.nomcdv as Condicion_Venta,d.Codi,LEFT(d.codi,7) as Codi_6,
	d.Codf,m.codcli Codigo_Cliente,m.nomcli as Cliente,M.mone AS Moneda,
 	(case when d.cdocu='07' then -1*d.cant else d.cant end) as Cantidad, 	
	(case when m.mone='S' then d.tota else d.tota*m.tcam end ) as TOTAL_SOLES,
	(case when m.mone='S' then d.tota else d.tota*m.tcam end )/(case when d.cdocu='07' then -1*d.cant else d.cant end) AS Precio_Unitario,
	D.totn as Total_Venta,
	m.tcam as Tipo_Cambio, 
	(Case When m.mone='D'  Then d.tota Else d.tota/d.tcam End) AS 'Dolares_SinIGV',
	(Case When m.mone='S'  Then d.tota Else d.tota*d.tcam End) AS 'Soles_SinIGV',
	(Case When m.mone='D'  Then d.totn Else d.totn/d.tcam End) AS 'Dolares_ConIGV',
	(Case When m.mone='S'  Then d.totn Else d.totn*d.tcam End) AS 'Soles_ConIGV',
	(Case When m.mone='S'  Then d.totn Else 0 End) AS 'OriginalSoles_ConIGV',
	(Case When m.mone='D'  Then d.totn Else 0 End) AS 'OriginalDolares_ConIGV',
	Equiv.abr_apssa AS ABR_IAP,Equiv.abr_gy AS ABR_GY,
	RTRIM(LTRIM(f.nomfam)) as Familia, LTRIM(RTRIM(s.nomsub)) as SubFamilia, RTRIM(LTRIM(g.nomgru)) as Grupo, LTRIM(RTRIM(p.descr)) as Item, p.marc as Marca,  
	zon.nomzonsuc as Zona, suc.nomsuc as Región,m.flag,m.codpto AS CODIGO_PUNTO,
	d.codalm as CODIGO_ALMACEN ,
	year(m.fecha) Anno_Emision,
	month(m.fecha) MesNro_Emision,
	case month(m.fecha) 
		when 1 then 'Enero'
		when 2 then 'Febrero'
		when 3 then 'Marzo'
		when 4 then 'Abril'
		when 5 then 'Mayo'
		when 6 then 'Junio'
		when 7 then 'Julio'
		when 8 then 'Agosto'
		when 9 then 'Setiembre'
		when 10 then 'Octubre'
		when 11 then 'Noviembre'
		when 12 then 'Diciembre'
	end as MesNombre_Emision,
	case month(m.fecha) 
		when 1 then '1-Enero'
		when 2 then '2-Febrero'
		when 3 then '3-Marzo'
		when 4 then '4-Abril'
		when 5 then '5-Mayo'
		when 6 then '6-Junio'
		when 7 then '7-Julio'
		when 8 then '8-Agosto'
		when 9 then '9-Setiembre'
		when 10 then '10-Octubre'
		when 11 then '11-Noviembre'
		when 12 then '12-Diciembre'
	end as MesNombre_Orden,
case when m.cdocu='01' then 'FACTURA'
	 when m.cdocu='03' then 'BOLETA'
	 when m.cdocu='07' then 'NC' 
	 WHEN m.cdocu='08' then 'ND'
end TipoDocumento,
 isnull((SELECT top 1 case when k.mone='S' THEN (preu/tcam) else preu end CostoUnitarioDolares
 from kdd0101 k where k.tmov='e' and k.codi=d.codi and k.fecha<=d.fecha order by fecha DESC),0) CostoUnitarioDolares,
 (SELECT top 1 case when k.mone='D' THEN (preu*tcam) else preu end CostoUnitarioSoles
 from kdd0101 k where k.tmov='e' and k.codi=d.codi and k.fecha<=d.fecha order by fecha DESC) CostoUnitarioSoles,
 
 (case when d.mone='S' THEN d.preu/d.tcam else d.preu end -
 (
 isnull((SELECT top 1 case when k.mone='S' THEN (preu/tcam) else preu end CostoDolares
 from kdd0101 k where k.tmov='e' and k.codi=d.codi and k.fecha<=d.fecha order by fecha DESC),0)
 ))/ (case when d.mone='S' THEN d.preu/d.tcam else d.preu end) PorcentajeMargenDolares,

 (case when d.mone='D' THEN (preu*m.tcam) else preu end -
 (
 isnull((SELECT top 1 case when k.mone='D' THEN (preu*tcam) else preu end CostoSoles
 from kdd0101 k where k.tmov='e' and k.codi=d.codi and k.fecha<=d.fecha order by fecha DESC),0)
 )) / (case when d.mone='D' THEN (preu*m.tcam) else preu end ) PorcentajeMargenSoles,
 CASE 
	WHEN M.cdocu='01' then 'F/'+m.ndocu
	when m.cdocu='03' then 'B/'+m.ndocu
	when m.cdocu='07' then 'NC/'+m.ndocu
	when m.cdocu='08' then 'ND/'+m.ndocu
end Numero_Documento2
FROM mst01fac M 
Join dtl01fac d on m.cdocu=d.cdocu and m.ndocu=d.ndocu
left Join Tbl01ven v on v.codven=m.codven 	
left Join Prd0101  p on d.codi=p.codi 	
left Join Tbl01Grp g on SubString(d.codi,1,2)+'-'+SubString(d.codi,3,2)+'-'+SubString(d.codi,6,2)=g.codgru 	
left Join Tbl01Sbf s on SubString(d.codi,1,2)+'-'+SubString(d.codi,3,2)=s.codsub 	
left Join Tbl01Fam f on SubString(d.codi,1,2)=f.codfam 	left Join Tbl01Pto Pto On M.CodPto=Pto.CodPto 	
left Join Tbl_Tienda Tie On Pto.CodTie=Tie.CodTie 	
left Join Tbl_Sucursal Suc On Pto.CodSuc=Suc.CodSuc 	
left Join Tbl_Zona_Sucursal Zon On Suc.CodZonSuc=Zon.CodZonSuc
left Join tbl_equivale Equiv On Equiv.codgru=g.codgru	
left Join Tbl01Scc Sc On  left(d.codscc,8)=Sc.codscc and Sc.nivel=3 --and substring(d.codscc,5,2) in ('95','96') 
left join Mst01ccc cc on cc.cdocu=m.cdocu and cc.ndocu=m.ndocu
left join tbl01cdv cv on cv.codcdv=m.Codcdv
Where 
d.flag<>'*' and d.codi<>'0000-000000'  AND D.fecha BETWEEN @FECHAI AND @FECHAF


union all

SELECT 
	tie.nomtie as Tienda,Sc.nomscc as SubCC,
	m.codscc,m.codven Codigo_Vendedor,v.nomven Vendedor,v.codsccmer,v.codsccree,
 	CONVERT (char(10), m.fecha, 103) As Fecha_Documento,
	CONVERT (char(10), m.fecha, 103) As Fecha_Vencimiento,
 	m.cdocu as Codigo_Documento,m.ndocu as Numero_Documento,
	cv.nomcdv as Condicion_Venta,d.Codi,LEFT(d.codi,7) as Codi_6,
	d.Codf,m.codcli Codigo_Cliente,m.nomcli as Cliente,M.mone AS Moneda,
 	(case when d.cdocu='07' then -1*d.cant else d.cant end) as Cantidad, 	
	(case when m.mone='S' then d.tota else d.tota*m.tcam end ) as TOTAL_SOLES,
	(case when m.mone='S' then d.tota else d.tota*m.tcam end )/(case when d.cdocu='07' then -1*d.cant else d.cant end) AS Precio_Unitario,
	D.totn as Total_Venta,
	m.tcam as Tipo_Cambio, 
	(Case When m.mone='D'  Then d.tota Else d.tota/d.tcam End) AS 'Dolares_SinIGV',
	(Case When m.mone='S'  Then d.tota Else d.tota*d.tcam End) AS 'Soles_SinIGV',
	(Case When m.mone='D'  Then d.totn Else d.totn/d.tcam End) AS 'Dolares_ConIGV',
	(Case When m.mone='S'  Then d.totn Else d.totn*d.tcam End) AS 'Soles_ConIGV',
	(Case When m.mone='S'  Then d.totn Else 0 End) AS 'OriginalSoles_ConIGV',
	(Case When m.mone='D'  Then d.totn Else 0 End) AS 'OriginalDolares_ConIGV',
	Equiv.abr_apssa AS ABR_IAP,Equiv.abr_gy AS ABR_GY,
	RTRIM(LTRIM(f.nomfam)) as Familia, LTRIM(RTRIM(s.nomsub)) as SubFamilia, RTRIM(LTRIM(g.nomgru)) as Grupo, LTRIM(RTRIM(p.descr)) as Item, p.marc as Marca,  
	zon.nomzonsuc as Zona, suc.nomsuc as Región,m.flag,m.codpto AS CODIGO_PUNTO,
	d.codalm as CODIGO_ALMACEN ,
	year(m.fecha) Anno_Emision,
	month(m.fecha) MesNro_Emision,
	case month(m.fecha) 
		when 1 then 'Enero'
		when 2 then 'Febrero'
		when 3 then 'Marzo'
		when 4 then 'Abril'
		when 5 then 'Mayo'
		when 6 then 'Junio'
		when 7 then 'Julio'
		when 8 then 'Agosto'
		when 9 then 'Setiembre'
		when 10 then 'Octubre'
		when 11 then 'Noviembre'
		when 12 then 'Diciembre'
	end as MesNombre_Emision,
	case month(m.fecha) 
		when 1 then '1-Enero'
		when 2 then '2-Febrero'
		when 3 then '3-Marzo'
		when 4 then '4-Abril'
		when 5 then '5-Mayo'
		when 6 then '6-Junio'
		when 7 then '7-Julio'
		when 8 then '8-Agosto'
		when 9 then '9-Setiembre'
		when 10 then '10-Octubre'
		when 11 then '11-Noviembre'
		when 12 then '12-Diciembre'
	end as MesNombre_Orden,
'OS' TipoDocumento,
 isnull((SELECT top 1 case when k.mone='S' THEN (preu/tcam) else preu end CostoUnitarioDolares
 from kdd0101 k where k.tmov='e' and k.codi=d.codi and k.fecha<=d.fecha order by fecha DESC),0) CostoUnitarioDolares,
 (SELECT top 1 case when k.mone='D' THEN (preu*tcam) else preu end CostoUnitarioSoles
 from kdd0101 k where k.tmov='e' and k.codi=d.codi and k.fecha<=d.fecha order by fecha DESC) CostoUnitarioSoles,
 
 (case when d.mone='S' THEN d.preu/d.tcam else d.preu end -
 (
 isnull((SELECT top 1 case when k.mone='S' THEN (preu/tcam) else preu end CostoDolares
 from kdd0101 k where k.tmov='e' and k.codi=d.codi and k.fecha<=d.fecha order by fecha DESC),0)
 ))/ (case when d.mone='S' THEN d.preu/d.tcam else d.preu end) PorcentajeMargenDolares,

 (case when d.mone='D' THEN (preu*m.tcam) else preu end -
 (
 isnull((SELECT top 1 case when k.mone='D' THEN (preu*tcam) else preu end CostoSoles
 from kdd0101 k where k.tmov='e' and k.codi=d.codi and k.fecha<=d.fecha order by fecha DESC),0)
 )) / (case when d.mone='D' THEN (preu*m.tcam) else preu end ) PorcentajeMargenSoles,
  CASE 
	WHEN M.cdocu='01' then 'F/'+m.ndocu
	when m.cdocu='03' then 'B/'+m.ndocu
	when m.cdocu='07' then 'NC/'+m.ndocu
	when m.cdocu='08' then 'ND/'+m.ndocu
end Numero_Documento2
FROM Mst_Orden_Servicio M 
Join Dtl_Orden_Servicio d on m.cdocu=d.cdocu and m.ndocu=d.ndocu
left Join Tbl01ven v on v.codven=m.codven 	
left Join Prd0101  p on d.codi=p.codi 	
left Join Tbl01Grp g on SubString(d.codi,1,2)+'-'+SubString(d.codi,3,2)+'-'+SubString(d.codi,6,2)=g.codgru 	
left Join Tbl01Sbf s on SubString(d.codi,1,2)+'-'+SubString(d.codi,3,2)=s.codsub 	
left Join Tbl01Fam f on SubString(d.codi,1,2)=f.codfam 	left Join Tbl01Pto Pto On M.CodPto=Pto.CodPto 	
left Join Tbl_Tienda Tie On Pto.CodTie=Tie.CodTie 	
left Join Tbl_Sucursal Suc On Pto.CodSuc=Suc.CodSuc 	
left Join Tbl_Zona_Sucursal Zon On Suc.CodZonSuc=Zon.CodZonSuc
left Join tbl_equivale Equiv On Equiv.codgru=g.codgru	
left Join Tbl01Scc Sc On  left(d.codscc,8)=Sc.codscc and Sc.nivel=3 --and substring(d.codscc,5,2) in ('95','96') 
left join Mst01ccc cc on cc.cdocu=m.cdocu and cc.ndocu=m.ndocu
left join tbl01cdv cv on cv.codcdv=m.Codcdv
Where 
d.flag<>'*' and d.codi<>'0000-000000'  AND D.fecha BETWEEN @FECHAI AND @FECHAF
and ltrim(rtrim(m.cfac))<>'' and ltrim(rtrim(m.nFac))<>''

end


go



ALTER procedure [dbo].[USP_UDP_GUARDAR_ARQUEO_OS]
(
	@fecha date,
	@estadoarqueo bit,
	@usuarioPC varchar(50),
	@codcdv varchar(2),
	@totalS numeric(18,2),
	@TotalD numeric(18,2)
)
as
begin

	if @codcdv='01'
	begin
			
			update Mst_Orden_Servicio set 
			flg_arqueado=@estadoarqueo,
			--fechaarqueo=case @estadoarqueo when 1 then getdate() else null end,
			fechaarqueo=case @estadoarqueo when 1 then case when fechaarqueo is null then getdate() else FechaArqueo end else null end,
			usuarioarqueo=case @estadoarqueo when 1 then @usuarioPC else null end
			where fecha=@fecha and codcdv='01'

			if(@estadoarqueo=0)
			begin
				delete from Mst_Orden_Servicio_Arqueo where fecha=@fecha and Tipo='E'
			end
			else
			begin
				insert into Mst_Orden_Servicio_Arqueo (Fecha,Tipo,TotalS,TotalD)
				values(GETDATE(),'E',@totalS,@TotalD)
			end
			
	end
	else
	begin
			update Mst_Orden_Servicio set 
			flg_arqueado=@estadoarqueo,
			fechaarqueo=case @estadoarqueo when 1 then case when fechaarqueo is null then getdate() else FechaArqueo end else null end,
			usuarioarqueo=case @estadoarqueo when 1 then @usuarioPC else null end
			where fecha=@fecha and codcdv <>'01'
			and isnull((totn-isnull(Cancelado,0)),0) =0


			if(@estadoarqueo=0)
			begin
				delete from Mst_Orden_Servicio_Arqueo where fecha=@fecha and Tipo='C'
			end
			else
			begin
				insert into Mst_Orden_Servicio_Arqueo (Fecha,Tipo,TotalS,TotalD)
				values(GETDATE(),'C',@totalS,@TotalD)
			end
	end
end

go



ALTER procedure [dbo].[USP_UDP_GUARDAR_CANCELACION_OS]
(
	@cdocu char(2),
	@ndocu varchar(12),
	@monto numeric(18,2)
)
AS
BEGIN
	declare @saldo numeric(18,4)=0
	select @saldo=ROUND(isnull((totn-isnull(Cancelado,0)),0),4) from Mst_Orden_Servicio where cdocu=@cdocu and ndocu=@ndocu

	if @saldo>0
	begin
		update Mst_Orden_Servicio set 
		Cancelado=ROUND(isnull(Cancelado,0)+@monto,4)
		where cdocu=@cdocu and ndocu=@ndocu
	end
	else
	begin
		RAISERROR('El saldo del documento es 0, solo es posible cancelar documentos con saldo superior a 0',16,1)
		return;
	end
	
END



go


ALTER PROCEDURE [dbo].[USP_SEL_OS_ARQUEO]
(
	@fecha date,
	@codcdv char(2)
)
AS
begin

declare @tbl table
( codcdv char(2))

if @codcdv='01' 
begin
	insert into @tbl values('01')
end
else
begin
	insert into @tbl select codcdv from tbl01cdv where codcdv<>'01'
end

	select fecha,cdocu,ndocu,nomcli,ruccli,os.codcdv,cv.nomcdv nombrecondicionventa,mone,tcam,tota,toti,totn,
	cast(isnull(flg_arqueado,0)as bit) flg_arqueado,fechaarqueo,usuarioArqueo,
	ROUND(isnull((totn-isnull(Cancelado,0)),0),4) Saldo,
	cast(case (ROUND(totn,4)-ROUND(Cancelado,4)) when 0 then 1 else 0 end as bit) Flag_Cancelado
	from Mst_Orden_Servicio os
	inner join tbl01cdv cv on os.codcdv=cv.codcdv
	where fecha=cast(@fecha as date)
	and os.flag <> '*'
	and os.codcdv in(select codcdv from @tbl)
end



go


ALTER procedure [dbo].[USP_SEL_EmailCliente]
(
	@ruccli varchar(11)
)
as
begin
	select top 1 email,nomcli from mst01cli where ruccli=@ruccli;
end



ALTER procedure [dbo].[usp_sel_ParametrosPlantillaOrdenServicio]
(
	@ndocu varchar(12),
	@Cod_Operario varchar(5),
	@Codi varchar(50),
	@item int
)
as
begin
	select ndocu,Cod_Operario,Codi,item,p1,p2,p3,p4,p5,p6,p7,p8,p9,p10,p11,p12,p13,p14,p15,p16,p17,p18,p19,p20
	from ParametrosPlantillaOrdenServicio where ndocu=@ndocu and Cod_Operario=@Cod_Operario and Codi=@Codi and item=@item  
end



ALTER procedure [dbo].[usp_ins_Parametros_PlantillasOrdenServicio]
(
	@ndocu varchar(12),
	@Cod_Operario varchar(5),
	@Codi varchar(50),
	@item int,
	@p1  varchar(3000),
	@p2  numeric(18,3),
	@p3  numeric(18,3),
	@p4  numeric(18,3),
	@p5  numeric(18,3),
	@p6  numeric(18,3),
	@p7  numeric(18,3),
	@p8  numeric(18,3),
	@p9  numeric(18,3),
	@p10 numeric(18,3),
	@p11 numeric(18,3),
	@p12 numeric(18,3),
	@p13 numeric(18,3),
	@p14 numeric(18,3),
	@p15 numeric(18,3),
	@p16 numeric(18,3),
	@p17 numeric(18,3),
	@p18 numeric(18,3),
	@p19 numeric(18,3),
	@p20 numeric(18,3)
)
as
begin
	if exists(select * from ParametrosPlantillaOrdenServicio where ndocu=@ndocu and Cod_Operario=@Cod_Operario and Codi=@Codi and item=@item)
	begin
		update ParametrosPlantillaOrdenServicio set
			   p1 = @p1 ,
			   p2 = @p2 ,
			   p3 = @p3 ,
			   p4 = @p4 ,
			   p5 = @p5 ,
			   p6 = @p6 ,
			   p7 = @p7 ,
			   p8 = @p8 ,
			   p9 = @p9 ,
			   p10= @p10,
			   p11= @p11,
			   p12= @p12,
			   p13= @p13,
			   p14= @p14,
			   p15= @p15,
			   p16= @p16,
			   p17= @p17,
			   p18= @p18,
			   p19= @p19,
			   p20= @p20
		where ndocu=@ndocu and Cod_Operario=@Cod_Operario and Codi=@Codi and item=@item  
	end
	else
	begin
		insert into ParametrosPlantillaOrdenServicio (ndocu,Cod_Operario,Codi,item,p1,p2,p3,p4,p5,p6,p7,p8,p9,p10,p11,p12,
		p13,p14,p15,p16,p17,p18,p19,p20)
		values (@ndocu,@Cod_Operario,@Codi,@item,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,
		@p13,@p14,@p15,@p16,@p17,@p18,@p19,@p20)
	end
end
ALTER procedure [dbo].[usp_udp_Actualizar_Operarios_OS]
(
	@ndocu varchar(12),
	@item int,
	@Cod_Operario varchar(6)
)
as
begin
	if ltrim(rtrim(@Cod_Operario))<>''
	begin
		update Dtl_Orden_Servicio set CodOte=@Cod_Operario where ndocu=@ndocu and item=@item
	end
	
	
end

USE [bdNava01_perfiles082019]
GO
/****** Object:  StoredProcedure [dbo].[usp_udp_Actualizar_Fechas_Proceso_OS]    Script Date: 14/09/2019 15:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--select * from Dtl_Orden_Servicio where ndocu='001-00005640'
--exec usp_udp_Actualizar_Fechas_Proceso_OS ''
ALTER procedure [dbo].[usp_udp_Actualizar_Fechas_Proceso_OS]
(	@ndocu varchar(12),
	@item int,
	@Cod_Operario varchar(5))
as
begin
	declare @fechainicio datetime,@fechafin datetime
	select @fechainicio=FechaInicioServicio,@fechafin=FechaFinServicio 
	from Dtl_Orden_Servicio where ndocu=@ndocu and item=@item

	if @fechafin is null and @fechainicio is null
	begin
		update Dtl_Orden_Servicio set FechaInicioServicio=GETDATE() where ndocu=@ndocu and item=@item
	end
	if @fechainicio is not null
	begin
		update Dtl_Orden_Servicio set FechaFinServicio=GETDATE() where ndocu=@ndocu and item=@item
	end

	set @fechainicio=null;
	set @fechafin=null;

	select top 1 @fechainicio=min(FechaInicioServicio),@fechafin=max(FechaFinServicio) from Dtl_Orden_Servicio where ndocu=@ndocu
	
	update Mst_Orden_Servicio set FechaInicioServicio=@fechainicio,FechaFinServicio=@fechafin where ndocu=@ndocu;

end