<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultarNota.aspx.cs" Inherits="ProyectooRelampago.ConsultarNota" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>

    <title>Consulta de notas</title>
</head>
<body>
    <div style="background-color: #0E034F; text-align: center; color: white; width: 100%;">
        <h1>Notas del estudiante</h1>
    </div>
    <div style="background-color: #970101; color: white; width: 30%; text-align: center;" runat="server">
        <h1>Cursos</h1>
    </div>
    <form id="form1" runat="server">
        <div id="ConsultarNota1" runat="server">
        </div>
        <div id="modalContainer"></div>

        <asp:Button Style="display: none;" ID="Button1" runat="server" Text="Acción 1" OnClick="btnAction_Click" />
    </form>
</body>
</html>
