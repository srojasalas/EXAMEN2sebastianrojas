<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="EXAMEN2sebastianrojas.Presentacion.Menu" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Menú Principal - Taller de Reparaciones</title>
    <link href="../css/Estilo.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <ul>
            <li><a class="active" href="Menu.aspx">Inicio</a></li>
            <li><a href="CatalogoUsuarios.aspx">Usuarios</a></li>
            <li><a href="CatalogoTecnicos.aspx">Técnicos</a></li>
        </ul>

        <div class="contenedor">
            <h1>Sistema de Gestión de Reparaciones</h1>
            <p>Bienvenido al sistema. Selecciona una opción del menú superior para administrar los catálogos:</p>
            <ul>
                <li style="float:none; background:none;"><a style="color:#2980b9; text-align:left; padding:8px 0;" href="CatalogoUsuarios.aspx">→ Ir a Gestión de Usuarios</a></li>
                <li style="float:none; background:none;"><a style="color:#2980b9; text-align:left; padding:8px 0;" href="CatalogoTecnicos.aspx">→ Ir a Gestión de Técnicos</a></li>
            </ul>
        </div>
    </form>
</body>
</html>