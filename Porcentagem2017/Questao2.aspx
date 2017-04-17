<%@ Page Title="" Language="C#" MasterPageFile="~/Estrutura.Master" AutoEventWireup="true" CodeBehind="Questao2.aspx.cs" Inherits="Porcentagem2017.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="topo" ContentPlaceHolderID="titulo" runat="server">
</asp:Content>

<asp:Content ID="conteudo" ContentPlaceHolderID="conteudo" runat="server">
    <asp:Label ID="q2" runat="server" Text="Questão 2 - " Font-Size="30pt"></asp:Label>
    <strong><%= getPontos() %> ponto</strong>
    <p>Exercício sobre fator de decréscimo. Para descontar 8,2% deve multiplicar o valor inicial por:</p>
    <p>Observação: 2 casas decimais.</p>
    <p>Padrão de resposta: 0,00 (vírgula separando inteiro de decimal).</p>
    <asp:TextBox ID="txtResp2" runat="server" Font-Size="30pt"></asp:TextBox>
    <p></p>
    <asp:Button ID="btn2_3" runat="server" Text="Ir para questão 3" Font-Size="30pt" OnClick="btn2_3_Click" />
</asp:Content>

<asp:Content ID="rodape" ContentPlaceHolderID="rodape" runat="server">
</asp:Content>
