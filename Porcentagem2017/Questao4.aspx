<%@ Page Title="" Language="C#" MasterPageFile="~/Estrutura.Master" AutoEventWireup="true" CodeBehind="Questao4.aspx.cs" Inherits="Porcentagem2017.Questao4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="titulo" ContentPlaceHolderID="titulo" runat="server">
</asp:Content>

<asp:Content ID="conteudo" ContentPlaceHolderID="conteudo" runat="server">
    <asp:Label ID="q4" runat="server" Text="Questão 4 - " Font-Size="30pt"></asp:Label>
    <strong><%= getPontos() %> pontos</strong>
    <p>Três amigos decidiram ficar com a mesma quantia de dinheiro. O primeiro tinha R$ 220,00, o segundo tinha R$ 350,00 e o terceiro nenhum centavo. Qual a porcentagem de dinheiro dado pela segunda pessoa que tinha inicialmente R$ 350,00?</p>
    <p>Observação: 2 casas decimais.</p>
    <p>Padrão de resposta: 1,01% (vírgula e sinal de %).</p>
    <asp:TextBox ID="txtResp4" runat="server" Font-Size="30pt"></asp:TextBox>
    <p />
    <asp:Button ID="btn4_5" runat="server" Text="Ir para questão 5" Font-Size="30pt" OnClick="btn4_5_Click" />
</asp:Content>

<asp:Content ID="rodape" ContentPlaceHolderID="rodape" runat="server">
</asp:Content>
