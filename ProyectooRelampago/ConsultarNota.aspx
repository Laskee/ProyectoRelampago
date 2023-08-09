<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultarNota.aspx.cs" Inherits="ProyectooRelampago.ConsultarNota" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>

    <title>Consulta de notas</title>
</head>
<body>
    <center><h1>Consulta de notas</h1></center>
    
    <form id="form1" runat="server">
        <div id="ConsultarNota1" runat="server">

        </div>
        <div id="modalContainer"></div>

        <asp:Button style="display: none;" ID="Button1" runat="server" Text="Acción 1" OnClick="btnAction_Click" />
    </form>
</body>
</html>
