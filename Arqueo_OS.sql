select * from Mst_Orden_Servicio
alter table Mst_Orden_Servicio
add flg_arqueado bit,
FechaArqueo date,
UsuarioArqueo varchar(50)


ALTER PROCEDURE [dbo].[USP_SEL_OS_ARQUEO]
(
	@fechainicial date,
	@fechafinal date,
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
	where fecha between cast(@fechainicial as date) and cast(@fechafinal as date)
	and os.flag <> '*'
	and os.codcdv in(select codcdv from @tbl)
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


ALTER PROCEDURE [dbo].[USP_SEL_OS_PENDIENTES]
(
	@CODCLI VARCHAR(50)
)
AS
begin

	select Fecha,ndocu NumeroDocumento,cv.nomcdv CondicionVenta,mone Moneda,totn Total,
	ROUND(isnull((totn-isnull(Cancelado,0)),0),4) Saldo
	
	from Mst_Orden_Servicio os
	inner join tbl01cdv cv on os.codcdv=cv.codcdv
	where LTRIM(RTRIM(os.ruccli))=LTRIM(RTRIM(@CODCLI))
	AND ROUND(isnull((totn-isnull(Cancelado,0)),0),4)>0
	and os.flag<>'*'
	order by os.fecha asc
end