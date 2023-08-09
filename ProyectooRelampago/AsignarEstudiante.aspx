<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AsignarEstudiante.aspx.cs" Inherits="ProyectooRelampago.AsignarEstudiante" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/css/bootstrap.min.css" />
    <script src="https://code.jquery.com/jquery-3.7.0.min.js"></script>
    <link rel="stylesheet" href="CSS/Estilo.css" />
    <title>Asignar estudiantes</title>
</head>
<body>
    <div style="text-align: center; margin-top: 3%; color: white; background-color: #0E034F">
        <h1>Asignacion de estudiantes a un curso</h1>
    </div>
    <form id="form1" runat="server" class="jumbotron" style="text-align:center;">
        <div>
            <asp:DropDownList ID="dropEstudiantes" runat="server"></asp:DropDownList>
        </div>

        <div>
            <asp:Button ID="btnagregar" class="btn Boton2" runat="server" Text="agregar" OnClick="btnagregar_Click" />
        </div>

        <div style="text-align:center;">
            <div>
                <div>
                    <h1>Lista de estudiantes</h1>
                </div>
            </div>
            <asp:GridView ID="gdvTabla" runat="server" style="background-color:#0E034F;color:white;" ></asp:GridView>
        </div>
    </form>
</body>
<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.14.7/dist/umd/popper.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/js/bootstrap.min.js"></script>
</html>
