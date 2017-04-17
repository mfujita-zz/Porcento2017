<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Giovane.aspx.cs" Inherits="Porcentagem2017.Giovane" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Giovane</title>
    <meta charset="utf-8" />
    <link href="css/idAlunos.css" rel="stylesheet" />
</head>
<body>
    <form id="aluno" runat="server">
    <div>
        <asp:Label class="nome" runat="server" Text="Identificação"></asp:Label>
        <p></p>
        <asp:Label class="nome" runat="server" Text="Giovane Dos Presentes Epifanio"></asp:Label>
        <p></p>
        <asp:Label ID="nome" runat="server" Text="Clique no botão se estiver correto."></asp:Label>
        <p></p>
        <asp:Button ID="confirmar" runat="server" Text="Confirmar" OnClick="confirmar_Click" />
    </div>
    </form>
</body>
</html>
