<%@ Page Title="" Language="C#" MasterPageFile="~/Estrutura.Master" AutoEventWireup="true" CodeBehind="Questao5.aspx.cs" Inherits="Porcentagem2017.Questao5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="titulo" ContentPlaceHolderID="titulo" runat="server">
</asp:Content>

<asp:Content ID="conteudo" ContentPlaceHolderID="conteudo" runat="server">
    <asp:Label ID="q5" runat="server" Text="Questão 5 - " Font-Size="30pt"></asp:Label>
    <strong><%= getPontos() %> pontos</strong>
    <p>Um salário é distribuído entre 4 despesas: moradia, alimentação, vestuário e transporte. A pessoa gasta 1/4 do salário com moradia, 35% do salário com alimentação, R$ 400,00 com vestuário e R$ 200,00 transporte. Então a despesa com moradia é igual a:.</p>
    <p>Observação: 2 casas decimais (centavos).</p>
    <p>Padrão de resposta: 12,34 (Vírgula separando parte inteira da decimal).</p>
    <asp:TextBox ID="txtResp5" runat="server" Font-Size="30pt"></asp:TextBox>
    <p />
    <asp:Button ID="btn5_fim" runat="server" Text="Finalizar" Font-Size="30pt" OnClick="btn5_fim_Click"/>
</asp:Content>

<asp:Content ID="rodape" ContentPlaceHolderID="rodape" runat="server">
</asp:Content>
