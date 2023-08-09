<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PanelProfesor.aspx.cs" Inherits="ProyectooRelampago.PanelProfesor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/css/bootstrap.min.css" />
    <script src="https://code.jquery.com/jquery-3.7.0.min.js"></script>
    <link rel="stylesheet" href="CSS/Estilo.css" />
    <title>Panel de control</title>
</head>
<body>
    <nav class="navbar" style="background-color: #0E034F">
        <a href=" 1.aspx" class="btn" style="width: 90%; color: white;background-color:#2906FC;width:30%">Asignacion de rubricas </a>
        <a href=" 2.aspx" class="btn" style="width: 90%; color: white;background-color:#2906FC;width:30%">Asignacion de estudiantes para un curso </a>
        <a href=" 3.aspx" class="btn" style="width: 90%; color: white;background-color:#2906FC;width:30%;">Asignar notas a los estudiantes</a>
        <a runat="server" class="btn BotonCerrarSesion" href="CerrarSesion.aspx" style="margin-left: revert; color: white">Cerrar Sesión</a>
    </nav>
    <form id="form1" runat="server">
        <div>
            <h1>Panel de control del profesor</h1>
        </div>
    </form>
</body>
<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.14.7/dist/umd/popper.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/js/bootstrap.min.js"></script>
</html>
