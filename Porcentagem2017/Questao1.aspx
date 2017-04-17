<%@ Page Title="" Language="C#" MasterPageFile="~/Estrutura.Master" AutoEventWireup="true" CodeBehind="Questao1.aspx.cs" Inherits="Porcentagem2017.Questao1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="titulo" ContentPlaceHolderID="titulo" runat="server">
</asp:Content>

<asp:Content ID="conteudo" ContentPlaceHolderID="conteudo" runat="server">
    <asp:Label ID="q1" runat="server" Text="Questão 1 - " Font-Size="30pt"></asp:Label>
    <strong><%= getPontos() %> ponto</strong>
    <p>Exercício sobre fator de acréscimo. Para aumentar em 5,75% deve-se multiplicar o valor inicial por:</p>
    <p>Observação: 2 casas decimais.</p>
    <p>Padrão de resposta: 0,00 (vírgula separando inteiro de decimal).</p>
    <asp:TextBox ID="txtResp1" runat="server" Font-Size="30pt"></asp:TextBox>
    <p />
    <asp:Button ID="btn1_2" runat="server" Text="Ir para questão 2" Font-Size="30pt" OnClick="btn1_2_Click" />
</asp:Content>

<asp:Content ID="rodape" ContentPlaceHolderID="rodape" runat="server">
</asp:Content>
