CREATE TABLE [dbo].[RepositorioXML](
	[Id] [varchar](50) NOT NULL,
	[Archivo] [xml] NULL,
 CONSTRAINT [PK_CP_GE_RepositorioXML] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


--obtencion del xml

ALTER procedure [dbo].[ObtenerXmlRepositorio]
(@NombreXml varchar(150))
as
begin
	select archivo from RepositorioXML where id=@NombreXml
end


--guardado de XML
DECLARE @xml AS XML


SET @xml = 
'
<Dashboard CurrencyCulture="es-PE">
  <Title Text="Tablero de control" />
  <DataSources>
    <SqlDataSource ComponentName="dashboardSqlDataSource1">
      <Name>Origen de datos SQL 1</Name>
      <Connection Name="localhost_bdNava01_Connection" ProviderKey="MSSqlServer">
        <Parameters>
          <Parameter Name="server" Value="localhost" />
          <Parameter Name="database" Value="bdNava01" />
          <Parameter Name="useIntegratedSecurity" Value="False" />
          <Parameter Name="read only" Value="1" />
          <Parameter Name="generateConnectionHelper" Value="false" />
          <Parameter Name="userid" Value="sa" />
          <Parameter Name="password" Value="sa" />
        </Parameters>
      </Connection>
      <Query Type="StoredProcQuery" Name="Sp_Olap_Ctaxc_ala_fechaActual">
        <ProcName>Sp_Olap_Ctaxc_ala_fechaActual</ProcName>
      </Query>
      <ResultSchema>
        <DataSet Name="Origen de datos SQL 1">
          <View Name="Sp_Olap_Ctaxc_ala_fechaActual">
            <Field Name="fecha" Type="DateTime" />
            <Field Name="TipoDocumento" Type="String" />
            <Field Name="nrodocumento" Type="String" />
            <Field Name="subccosto" Type="String" />
            <Field Name="area" Type="String" />
            <Field Name="cliente" Type="String" />
            <Field Name="departamento" Type="String" />
            <Field Name="provincia" Type="String" />
            <Field Name="actividad" Type="String" />
            <Field Name="categoría" Type="String" />
            <Field Name="zona" Type="String" />
            <Field Name="documento" Type="String" />
            <Field Name="Vendedor" Type="String" />
            <Field Name="condición" Type="String" />
            <Field Name="tipocliente" Type="String" />
            <Field Name="estadoletra" Type="String" />
            <Field Name="banco" Type="String" />
            <Field Name="cuenta" Type="String" />
            <Field Name="Vencidos" Type="String" />
            <Field Name="año" Type="String" />
            <Field Name="trimestre" Type="String" />
            <Field Name="mes" Type="String" />
            <Field Name="semana" Type="String" />
            <Field Name="dia" Type="String" />
            <Field Name="vencidons" Type="Decimal" />
            <Field Name="vencidous" Type="Decimal" />
            <Field Name="por_vencerns" Type="Decimal" />
            <Field Name="por_vencerus" Type="Decimal" />
            <Field Name="saldons" Type="Decimal" />
            <Field Name="saldous" Type="Decimal" />
          </View>
        </DataSet>
      </ResultSchema>
      <ConnectionOptions CloseConnection="true" CommandTimeout="0" />
    </SqlDataSource>
  </DataSources>
  <Items>
    <Grid ComponentName="gridDashboardItem1" Name="Resumen x Centro de Costo" DataSource="dashboardSqlDataSource1" DataMember="Sp_Olap_Ctaxc_ala_fechaActual">
      <DataItems>
        <Dimension DataMember="area" Name="CentroCosto" DefaultId="DataItem0" />
        <Measure DataMember="vencidons" Name="Total Vencido S/" DefaultId="DataItem1">
          <NumericFormat FormatType="Number" Unit="Ones" IncludeGroupSeparator="true" />
        </Measure>
        <Measure DataMember="vencidous" Name="Total Vencido $" DefaultId="DataItem2">
          <NumericFormat FormatType="Number" Unit="Ones" IncludeGroupSeparator="true" />
        </Measure>
      </DataItems>
      <GridColumns>
        <GridDimensionColumn Weight="68.112244897959187">
          <Dimension DefaultId="DataItem0" />
        </GridDimensionColumn>
        <GridMeasureColumn Weight="72.704081632653057">
          <Measure DefaultId="DataItem1" />
        </GridMeasureColumn>
        <GridMeasureColumn Weight="84.183673469387756">
          <Measure DefaultId="DataItem2" />
        </GridMeasureColumn>
      </GridColumns>
      <GridOptions ColumnWidthMode="Manual" />
    </Grid>
    <Chart ComponentName="chartDashboardItem1" Name="Detalle x Vendedor" DataSource="dashboardSqlDataSource1" DataMember="Sp_Olap_Ctaxc_ala_fechaActual">
      <ColoringOptions MeasuresColoringMode="Hue" />
      <InteractivityOptions IsDrillDownEnabled="true" />
      <DataItems>
        <Dimension DataMember="Vendedor" DefaultId="DataItem0" />
        <Measure DataMember="vencidons" DefaultId="DataItem1">
          <NumericFormat FormatType="Number" Unit="Ones" IncludeGroupSeparator="true" />
        </Measure>
        <Dimension DataMember="nrodocumento" DefaultId="DataItem4" />
        <Dimension DataMember="TipoDocumento" DefaultId="DataItem2" />
      </DataItems>
      <Arguments>
        <Argument DefaultId="DataItem0" />
        <Argument DefaultId="DataItem2" />
        <Argument DefaultId="DataItem4" />
      </Arguments>
      <Panes>
        <Pane Name="Panel 1">
          <Series>
            <Simple Name="Monto Vencido S/" SeriesType="Line">
              <Value DefaultId="DataItem1" />
            </Simple>
          </Series>
        </Pane>
      </Panes>
    </Chart>
    <Pie ComponentName="pieDashboardItem1" Name="Tipos de Vencimiento (dias)" DataSource="dashboardSqlDataSource1" DataMember="Sp_Olap_Ctaxc_ala_fechaActual" ShowPieCaptions="false">
      <InteractivityOptions IsDrillDownEnabled="true" />
      <DataItems>
        <Measure DataMember="vencidons" DefaultId="DataItem2" />
        <Dimension DataMember="Vencidos" DefaultId="DataItem0" />
      </DataItems>
      <Arguments>
        <Argument DefaultId="DataItem0" />
      </Arguments>
      <Values>
        <Value DefaultId="DataItem2" />
      </Values>
    </Pie>
    <Pivot ComponentName="pivotDashboardItem1" Name="Detalle Documentos vencidos" DataSource="dashboardSqlDataSource1" DataMember="Sp_Olap_Ctaxc_ala_fechaActual">
      <DataItems>
        <Dimension DataMember="area" DefaultId="DataItem0" />
        <Measure DataMember="vencidons" Name="Monto Vencido S/" DefaultId="DataItem1">
          <NumericFormat FormatType="Number" Unit="Ones" IncludeGroupSeparator="true" />
        </Measure>
        <Measure DataMember="vencidous" Name="Monto Vencido $" DefaultId="DataItem2">
          <NumericFormat FormatType="Number" Unit="Ones" IncludeGroupSeparator="true" />
        </Measure>
        <Dimension DataMember="Vendedor" DefaultId="DataItem3" />
        <Dimension DataMember="cliente" DefaultId="DataItem4" />
        <Dimension DataMember="nrodocumento" DefaultId="DataItem5" />
        <Measure DataMember="por_vencerns" Name="Monto Por Vencer S/" DefaultId="DataItem6">
          <NumericFormat FormatType="Number" Unit="Ones" IncludeGroupSeparator="true" />
        </Measure>
        <Measure DataMember="por_vencerus" Name="Monto Por Vencer $" DefaultId="DataItem7">
          <NumericFormat FormatType="Number" Unit="Ones" IncludeGroupSeparator="true" />
        </Measure>
        <Dimension DataMember="fecha" DateTimeGroupInterval="MonthYear" DefaultId="DataItem8" />
      </DataItems>
      <Rows>
        <Row DefaultId="DataItem0" />
        <Row DefaultId="DataItem3" />
        <Row DefaultId="DataItem4" />
        <Row DefaultId="DataItem8" />
        <Row DefaultId="DataItem5" />
      </Rows>
      <Values>
        <Value DefaultId="DataItem1" />
        <Value DefaultId="DataItem2" />
        <Value DefaultId="DataItem6" />
        <Value DefaultId="DataItem7" />
      </Values>
    </Pivot>
  </Items>
  <LayoutTree>
    <LayoutGroup Orientation="Vertical">
      <LayoutGroup Weight="48.777506112469439">
        <LayoutGroup Orientation="Vertical" Weight="39.935275080906152">
          <LayoutItem DashboardItem="gridDashboardItem1" Weight="31.328320802005013" />
          <LayoutItem DashboardItem="pieDashboardItem1" Weight="68.67167919799499" />
        </LayoutGroup>
        <LayoutItem DashboardItem="pivotDashboardItem1" Weight="60.064724919093848" />
      </LayoutGroup>
      <LayoutItem DashboardItem="chartDashboardItem1" Weight="51.222493887530561" />
    </LayoutGroup>
  </LayoutTree>
</Dashboard>
'

update RepositorioXML set Archivo=@xml WHERE ID='DocumentosCxC'


--insert into RepositorioXML (id) values('DocumentosCxC')

SELECT * FROM RepositorioXML


---------------------------------------  CREACION DE STORE PROCEDURE -------------------------
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

	

---------------------------------------------------------
