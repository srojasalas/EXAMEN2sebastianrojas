<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CatalogoUsuarios.aspx.cs" Inherits="EXAMEN2sebastianrojas.Presentacion.CatalogoUsuarios" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Catálogo de Usuarios</title>
    <link href="../css/Estilo.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <ul>
            <li><a href="Menu.aspx">Inicio</a></li>
            <li><a class="active" href="CatalogoUsuarios.aspx">Usuarios</a></li>
            <li><a href="CatalogoTecnicos.aspx">Técnicos</a></li>
        </ul>

        <div class="contenedor">
            <h2>Gestión de Usuarios</h2>
            <asp:GridView ID="gvUsuarios" runat="server" AutoGenerateColumns="true"></asp:GridView>
            <br />
            ID (Para Modificar/Borrar): <asp:TextBox ID="txtID" runat="server"></asp:TextBox><br /><br />
            Nombre: <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br /><br />
            Correo: <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox><br /><br />
            Teléfono: <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox><br /><br />
            
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
            <asp:Button ID="btnBorrar" runat="server" Text="Borrar" OnClick="btnBorrar_Click" />
        </div>
    </form>
</body>
</html>