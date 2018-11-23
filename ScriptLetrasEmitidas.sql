
alter procedure USP_SEL_LETRASEMITIDAS
(
	@FECHAINICIAL datetime,
	@FECHAFINAL	  datetime,
	@NOMBRECLIENTE VARCHAR(250),
	@NROLETRA		VARCHAR(50)
)
AS
BEGIN
	IF LTRIM(RTRIM(@NOMBRECLIENTE))=''
		SET @NOMBRECLIENTE=NULL;
	IF LTRIM(RTRIM(@NROLETRA))=''
		SET @NROLETRA=NULL;

	SELECT ccc.fecha,ccc.cdocu,ccc.ndocu,ccc.crefe,ccc.nrefe,ccc.codcli,c.ruccli,c.nomcli,
	ccc.monto,ccc.saldo,ccc.glosa,ccc.dias,ccc.fven,ccc.tcam,ccc.mone,nomest = 
	(SELECT nomest FROM tbl01est WHERE codest=ccc.codest), 
	nomsub = (Select nomsub From tbl01est_subest Where subest=ccc.subest),
	nombcox=(SELECT nombco FROM tbl01bco WHERE codbco=ccc.codbco),
	D.nomdis,P.nompro,c.dircli,c.CodDis,c.CodPro,
	c.Telcli,c.RucAva,c.nomava,c.dirAva,c.TelAva 
	FROM mst01ccc  ccc WITH(nolock) 
	inner join mst01cli c on ccc.codcli=c.codcli
	LEFT JOIN tbl01pro p ON c.codpai=p.codpai and c.coddep=p.coddep and c.codpro=p.codpro    
	LEFT JOIN tbl01dis d ON c.codpai=d.codpai and c.coddep=d.coddep and c.codpro=d.codpro and c.coddis=d.coddis  
	WHERE  cdocu='33'  And fecha BETWEEN cast(@FECHAINICIAL as date)  And cast(@FECHAFINAL as date) AND
	(@NOMBRECLIENTE IS NULL OR C.nomcli LIKE '%' + @NOMBRECLIENTE +'%') AND
	(@NROLETRA IS NULL OR ccc.ndocu like @NROLETRA+'%')
	ORDER BY fecha
END