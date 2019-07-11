
create PROCEDURE [dbo].[Sp_Olap_Ctaxc_ala_fechaActual]
As 
SELECT m.fecha,doc.nomdoc TipoDocumento,m.ndocu as nrodocumento,
tie.nomtie as subccosto, scc.nomscc as area, cli.nomcli As cliente,
	IsNull(dep.nomdep,'(Ninguno)') As departamento,
	IsNull(pro.nompro,'(Ninguno)') As provincia,
	IsNull(act.nomact,'(Ninguno)') As actividad,
	IsNull(cat.nomcat,'(Ninguno)') As categoría,
	IsNull(zon.nomzon,'(Ninguno)') As zona,
	IsNull(doc.nomdoc,'(Ninguno)') As documento,
	IsNull(ven.nomven,'(Ninguno)') As Vendedor,
	IsNull(cdv.nomcdv,'(Ninguno)') As condición ,
	IsNull(tcl.nomtcl,'(Ninguno)') As tipocliente,
	IsNull(ele.nomest,'(Ninguno)') As estadoletra,
	IsNull(bco.nombco,'(Ninguno)') As banco,
	M.cuenta    As cuenta,
        Case When Datediff(day,m.fven,getdate()) <= 0  Then 'Por_Vencer' Else 
	Case When Datediff(day,m.fven,getdate()) BetWeen 0 And 30  Then 'V_30' Else 
	Case When Datediff(day,m.fven,getdate()) BetWeen 0 And 45  Then 'V_45' Else 
	Case When Datediff(day,m.fven,getdate()) BetWeen 0 And 60  Then 'V_60' Else 
	Case When Datediff(day,m.fven,getdate()) BetWeen 0 And 90  Then 'V_90' Else 'V_Mayor_90' End End End End End As Vencidos,
	Convert(Char(4), Year(m.fecha) ) As año, 
       'Trim.' + Convert(Char(1),DATEPART (quarter,m.fecha)) As trimestre,  
	Dbo.Sp_JalaMes(Month(m.fecha),1)  As mes,    
      	'Sem.' + Convert(Char(1),  (datepart(week, m.fecha ) - datepart(week, convert(char(6), m.fecha,112 ) + '01')) + 1 )  As semana,  
	RIGHT('00'+Convert(Varchar(2), Day( m.fecha )),2) As dia, 
             Case When Datediff(day,m.fven,getdate()) > 0  Then Case When m.mone='S' Then m.saldo Else m.saldo*m.tcam End Else 0 End As vencidons,
	Case When Datediff(day,m.fven,getdate()) > 0  Then Case When m.mone='D' Then m.saldo Else m.saldo/m.tcam End Else 0 End As vencidous,
             Case When Datediff(day,m.fven,getdate()) <= 0  Then Case When m.mone='S' Then m.saldo Else m.saldo*m.tcam End Else 0 End As por_vencerns,
	Case When Datediff(day,m.fven,getdate()) <= 0  Then Case When m.mone='D' Then m.saldo Else m.saldo/m.tcam End Else 0 End As por_vencerus,
	Case When m.mone='S' Then m.saldo Else m.saldo*m.tcam End As saldons,
	Case When m.mone='D' Then m.saldo Else m.saldo/m.tcam End As saldous
	FROM mst01ccc m WITH (nolock)
	LEFT JOIN mst01cli cli WITH (nolock) ON m.codcli   = cli.codcli	
	LEFT JOIN tbl01dep dep WITH (nolock) ON cli.codpai = dep.codpai And cli.coddep = dep.coddep
	LEFT JOIN tbl01pro pro WITH (nolock) ON cli.codpai = pro.codpai And cli.coddep = pro.coddep And cli.codpro = pro.codpro
       LEFT JOIN tbl01zon zon WITH (nolock) ON cli.codzon = zon.codzon	
       LEFT JOIN tbl01act act WITH (nolock) ON cli.codact = act.codact
	LEFT JOIN tbl01cac cat WITH (nolock) ON cli.codcat = cat.codcat	
	LEFT JOIN tbl01tcl tcl WITH (nolock) ON cli.tipocl = tcl.codtcl
	LEFT JOIN tbl01doc doc WITH (nolock) ON m.cdocu  = doc.cdocu
	LEFT JOIN tbl01est ele WITH (nolock) ON m.codest = ele.codest
	LEFT JOIN tbl01ven ven WITH (nolock) ON m.codven = ven.codven
	LEFT JOIN tbl01cdv cdv WITH (nolock) ON m.codcdv = cdv.codcdv
	LEFT JOIN tbl01bco bco WITH (nolock) ON m.codbco = bco.codbco	
	LEFT JOIN tbl_tienda tie WITH (nolock) ON substring(m.codscc,3,2)=right(tie.codtie,2)
	LEFT JOIN tbl_subccosto scc WITH (nolock) ON substring(m.codscc,7,2)=substring(scc.codscc,5,2) and scc.nivel=3 and substring(scc.codscc,3,2)='95'
	WHERE  m.flag='0'

	