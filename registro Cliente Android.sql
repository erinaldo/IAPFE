﻿
create PROCEDURE [dbo].[USP_INS_CLIENTESUNAT_ANDROID]
(
	@RUC VARCHAR(11),
	@NOMBRECOMERCIAL VARCHAR(250),
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
