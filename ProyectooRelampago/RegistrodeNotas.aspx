<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrodeNotas.aspx.cs" Inherits="ProyectooRelampago.RegistrodeNotas" %>

<!DOCTYPE html>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/css/bootstrap.min.css" />
<script src="https://code.jquery.com/jquery-3.7.0.min.js"></script>
<link rel="stylesheet" href="CSS/Registro.css" />
<link rel="stylesheet" href="CSS/Estilo.css" />
<title>Registro de notas</title>
<html>
<head>
    <title>Formulario de Registro de Notas</title>
</head>
<body>
    <nav class="navbar" style="background-color: #0E034F">
        <a href=" 1.aspx" class="btn" style="width: 90%; color: white; background-color: #2906FC; width: 30%">Asignacion de rubricas </a>
        <a href=" RegistrodeNotas.aspx" class="btn" style="width: 90%; color: white; background-color: #2906FC; width: 30%;">Asignar notas a los estudiantes</a>
        <a runat="server" class="btn BotonCerrarSesion" href="CerrarSesion.aspx" style="margin-left: revert; color: white">Cerrar Sesión</a>
    </nav>
    <div id="registro-box">

        <h2>Registro de notas</h2>
        <form method="post" runat="server">

            <label for="correo">Estudiante:</label>
            <input runat="server" type="email" id="correo" name="correo" required>

            <label for="contrasena">Rubrica:</label>
            <input runat="server" type="password" id="contrasena" name="contrasena" required>

            <label for="nombre">Nota:</label>
            <input runat="server" type="text" id="nombre" name="nombre" required>


            <asp:Button ID="Button1" runat="server" Text="Registrar Nota" />
        </form>
    </div>

</body>
<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.14.7/dist/umd/popper.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/js/bootstrap.min.js"></script>
</html>
