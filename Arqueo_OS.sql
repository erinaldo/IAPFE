select * from Mst_Orden_Servicio
alter table Mst_Orden_Servicio
add flg_arqueado bit,
FechaArqueo date,
UsuarioArqueo varchar(50)


CREATE PROCEDURE USP_SEL_OS_ARQUEO
(
	@fecha date
)
AS
select fecha,cdocu,ndocu,nomcli,ruccli,os.codcdv,cv.nomcdv nombrecondicionventa,mone,tcam,tota,toti,totn,flg_arqueado,fechaarqueo,usuarioArqueo
from Mst_Orden_Servicio os
inner join tbl01cdv cv on os.codcdv=cv.codcdv
where fecha=@fecha
and os.flag <> '*'

create procedure USP_UDP_GUARDAR_ARQUEO_OS
(
	@fecha date,
	@estadoarqueo bit,
	@usuarioPC varchar(50),
	@codcdv varchar(2)
)
as
begin

	if @codcdv='01'
	begin
			update Mst_Orden_Servicio set 
			flg_arqueado=@estadoarqueo,
			fechaarqueo=case @estadoarqueo when 1 then getdate() else null end,
			usuarioarqueo=case @estadoarqueo when 1 then @usuarioPC else null end
			where fecha=@fecha and codcdv='01'
	end
	else
	begin
			update Mst_Orden_Servicio set 
			flg_arqueado=@estadoarqueo,
			fechaarqueo=case @estadoarqueo when 1 then getdate() else null end,
			usuarioarqueo=case @estadoarqueo when 1 then @usuarioPC else null end
			where fecha=@fecha and codcdv <>'01'
	end
	

	
end