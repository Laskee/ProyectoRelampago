<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="ProyectooRelampago.Registro" %>

    <link rel="stylesheet" href="CSS/Registro.css"/>
 <!DOCTYPE html>
<html>
<head>
    <title>Formulario de Registro</title>
</head>
<body>

<div id="registro-box">
    <h2>Registro</h2>
    <form  method="post" runat="server">

        <label for="correo">Correo:</label>
        <input runat="server" type="email" id="correo" name="correo" required>

        <label for="contrasena">Contraseña:</label>
        <input runat="server" type="password" id="contrasena" name="contrasena" required>

        <label for="nombre">Nombre Completo:</label>
        <input runat="server" type="text" id="nombre" name="nombre" required>

        <label>
            <input runat="server" type="checkbox" id="es_profesor" name="es_profesor">
            ¿Es Profesor?
        </label>
        <asp:Button ID="Button1" runat="server" Text="Registrar" OnClick="Button1_Click" />
        <button type="button" onclick="window.history.back();">Atrás</button>
    </form>
</div>

</body>
</html>

