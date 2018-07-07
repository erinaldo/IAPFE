<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="IAP.WEB.Login" %>

<!DOCTYPE html>
<html lang="es">
	<head>
		<title></title>
        <script type="text/javascript">
     
        function alerta(numero) {
            alert('El usuario ' + numero + ' no existe');
        }
     
    </script>
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
        <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" />
        <link href="bootstrap/csslogin/login_css.css" rel="stylesheet" />
	</head>

	<body>
        <div id="Contenedor">
            <div class="Icon">
                <img src="Image/login_medium.png" />
                <%--<span class="glyphicon glyphicon-user"></span>--%>
            </div>
            <div class="ContentForm">
                <form  method="post" name="FormEntrar" runat="server">
                    <div class="input-group input-group-lg">
                        <span class="input-group-addon" id="sizing-addon1"><i class="glyphicon glyphicon-envelope"></i></span>
                        <%--<input type="email" class="form-control" name="correo" placeholder="Correo" id="Correo" aria-describedby="sizing-addon1" required>--%>
                        <asp:TextBox CssClass="form-control" id="txtcorreo" runat="server" aria-describedby="sizing-addon1" placeholder="Correo" required autofocus></asp:TextBox>
                    </div>
                    <br>
                    <div class="input-group input-group-lg">
                        <span class="input-group-addon" id="sizing-addon2"><i class="glyphicon glyphicon-lock"></i></span>
                        <%--<input type="password" name="contra" class="form-control" placeholder="******" aria-describedby="sizing-addon1" required>--%>
                        <asp:TextBox runat="server" type="password" ID="txtcontrasena" name="contra" class="form-control" placeholder="Contraseña" aria-describedby="sizing-addon1" required></asp:TextBox>
                    </div>
                    <br>
                    <div class="row">
                        <div class="col-md-6">
                            <asp:Button runat="server" class="btn btn-lg btn-primary btn-block btn-signin" id="btncliente" Text="Cliente" OnClick="btncliente_Click"/>
                        </div>
                        <div class="col-md-6">
                            <asp:Button runat="server" class="btn btn-lg btn-primary btn-block btn-signin" id="btnusuario" Text="Usuario"/>
                        </div>
                    </div>
                    
                    
                    <div class="opcioncontra"><a href="">Olvidaste tu contraseña?</a></div>
                </form>
            </div>
        </div>
        <script src="bootstrap/js/jquery.js"></script>
        <script src="bootstrap/js/bootstrap.min.js"></script>
	</body>
</html>