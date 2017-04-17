<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="Porcentagem2017.inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Recursos Humanos</title>
    <link href="css/estilo.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
</head>

<body style="max-width:500px;">
    <div class="inicio">
        <form id="form1" runat="server">
            <asp:Label ID="lblRA" runat="server" Text="Digite seu RA (Registro Acadêmico)" Font-Size="30pt"></asp:Label>
            <p></p>
            <asp:TextBox ID="txtRA" runat="server" Font-Size="30pt"></asp:TextBox>
            <p></p>
            <asp:Button ID="btnRA" runat="server" Text="Confirmar" Font-Size="30pt" style="position:relative; left:3%" OnClick="btnRA_Click" />
<%--            <asp:Button ID="btn_01" runat="server" Text="Confirmar" OnClick="btn_01_Click" Font-Size="30pt" style="position:relative; left:3%" />--%>
        </form>
    </div>
</body>
</html>
