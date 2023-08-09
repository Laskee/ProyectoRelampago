<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarCurso.aspx.cs" Inherits="ProyectooRelampago.AgregarCurso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/AgregarCurso.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Agregar Curso</h1>
            <div class="seleccionar-curso">
                <asp:Label id="Label1" runat="server" Text="Curso"></asp:Label>
                <asp:Label id="Label2" runat="server" Text="Grupo"></asp:Label>
                <asp:DropDownList ID="DropDownList1" class="dd1" runat="server"></asp:DropDownList>
                <asp:DropDownList ID="DropDownList2" class="dd2" runat="server"></asp:DropDownList>
                <asp:Button id="Button1" runat="server" Text="Seleccionar" />
            </div>

            <div class="rubrica">
                <h1>Rubrica del Curso</h1>
                <input id="Text1" type="text" />
                <input id="Text2" type="text" />
                <asp:Button id="Button2" runat="server" Text="Agregar" />
            </div>

            <div class="grid-container">
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
