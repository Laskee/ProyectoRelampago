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
    <form action="/ruta/para/registro" method="post">

        <label for="correo">Correo:</label>
        <input type="email" id="correo" name="correo" required>

        <label for="contrasena">Contraseña:</label>
        <input type="password" id="contrasena" name="contrasena" required>

        <label for="nombre">Nombre Completo:</label>
        <input type="text" id="nombre" name="nombre" required>

        <label>
            <input type="checkbox" id="es_profesor" name="es_profesor">
            ¿Es Profesor?
        </label>

        <button type="submit">Registrar</button>
        <button type="button" onclick="window.history.back();">Atrás</button>
    </form>
</div>

</body>
</html>

