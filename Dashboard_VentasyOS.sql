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
	f.nomfam as Familia, s.nomsub as SubFamilia, g.nomgru as Grupo, p.descr as Item, p.marc as Marca,  
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
end TipoDocumento
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
	f.nomfam as Familia, s.nomsub as SubFamilia, g.nomgru as Grupo, p.descr as Item, p.marc as Marca,  
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
'OS' TipoDocumento
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