alter table Dtl_Orden_Servicio
	add [FechaInicioServicio] [datetime] NULL,
	[FechaFinServicio] [datetime] NULL


alter table Mst_Orden_Servicio
add 
[Cancelado] [numeric](18, 2) NULL,
	[IdPedido] [numeric](18, 0) NULL,
	[DirEnt] [varchar](5000) NULL,
	[CodUsuarioRegistro] [varchar](50) NULL,
	[flag_Estadopedido] [int] NULL,
	[Cod_Operario] [varchar](5) NULL,
	[FechaInicioServicio] [datetime] NULL,
	[FechaFinServicio] [datetime] NULL
	

CREATE TABLE [dbo].[tbl_EnvioDocumentosElectronicos](
	[Id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[cdocu] [char](2) NULL,
	[ndocu] [varchar](25) NULL,
	[flag_enviado] [bit] NULL,
	[FechaEnvio] [datetime] NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tbl_EnvioDocumentosElectronicos] ADD  DEFAULT ((0)) FOR [flag_enviado]
GO



CREATE TABLE [dbo].[ParametrosPlantillaOrdenServicio](
	[ndocu] [varchar](12) NULL,
	[Cod_Operario] [varchar](5) NULL,
	[Codi] [varchar](50) NULL,
	[item] [int] NULL,
	[p1] varchar(3000) NULL,
	[p2] [numeric](18, 3) NULL,
	[p3] [numeric](18, 3) NULL,
	[p4] [numeric](18, 3) NULL,
	[p5] [numeric](18, 3) NULL,
	[p6] [numeric](18, 3) NULL,
	[p7] [numeric](18, 3) NULL,
	[p8] [numeric](18, 3) NULL,
	[p9] [numeric](18, 3) NULL,
	[p10] [numeric](18, 3) NULL,
	[p11] [numeric](18, 3) NULL,
	[p12] [numeric](18, 3) NULL,
	[p13] [numeric](18, 3) NULL,
	[p14] [numeric](18, 3) NULL,
	[p15] [numeric](18, 3) NULL,
	[p16] [numeric](18, 3) NULL,
	[p17] [numeric](18, 3) NULL,
	[p18] [numeric](18, 3) NULL,
	[p19] [numeric](18, 3) NULL,
	[p20] [numeric](18, 3) NULL
) ON [PRIMARY]
GO

