<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrodeNotas.aspx.cs" Inherits="ProyectooRelampago.RegistrodeNotas" %>

 <!DOCTYPE html>
<link rel="stylesheet" href="CSS/Registro.css"/>
<html>
<head>
    <title>Formulario de Registro de Notas</title>
</head>
<body>

<div id="registro-box">
    <h2>Registro de notas</h2>
    <form  method="post" runat="server">

        <label for="correo">Estudiante:</label>
        <input runat="server" type="email" id="correo" name="correo" required>

        <label for="contrasena">Rubrica:</label>
        <input runat="server" type="password" id="contrasena" name="contrasena" required>

        <label for="nombre">Nota:</label>
        <input runat="server" type="text" id="nombre" name="nombre" required>

     
        <asp:Button ID="Button1" runat="server" Text="Registrar Nota"  />
    </form>
</div>

</body>
</html>