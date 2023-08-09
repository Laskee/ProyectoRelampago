<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectooRelampago.Login" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/css/bootstrap.min.css" />
    <script src="https://code.jquery.com/jquery-3.7.0.min.js"></script>
    <link rel="stylesheet" href="CSS/Estilo.css"/>
    <title>Inicio de sesión</title>
</head>
<body style="background-color:white">
        <div class="container mt-5" >
            <div class="row">
                <form class="mx-auto jumbotron Login" runat="server" style="width: 400px;background-color:#0E034F">
                    <div class="form-group" style="margin-left: 20%;">
                        <img runat="server" src="~/Imagen/Logo.jpg" style="width:60%;height:60%;border-radius:10%"/>
                    </div>
                    <div class="form-group" style="margin-left:20%">
                        <asp:TextBox ID="txtCorreo" runat="server" placeholder="Correo" required="true"></asp:TextBox>
                    </div>

                    <div class="form-group" style="margin-left:20%" >
                        <asp:TextBox ID="txtContrasenia" type="password" placeholder="Contraseña" runat="server"  required="true"></asp:TextBox>
                    </div>
                    <div class="form-group" style="margin-left:15%">
                        <asp:Label ID="lblMensaje" CssClass="text-dark" runat="server" Text=""></asp:Label>
                    </div>
                    <div class="form-group row" style="margin-left: 20%;">
                        <asp:Button ID="Conectar" runat="server" class="btn Boton1" Text="Ingresar" OnClick="Conectar_Click" />
                        <a runat="server" class="btn Boton1" href="Registro.aspx" style="margin-left:3%" >Registrarse</a>
                    </div>
                </form>
            </div>
        </div>
        
    </body>
        <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" ></script>
        <script src="https://cdn.jsdelivr.net/npm/popper.js@1.14.7/dist/umd/popper.min.js" ></script>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/js/bootstrap.min.js"></script>
</html>

