<%@ Page Title="" Language="C#" MasterPageFile="~/Estrutura.Master" AutoEventWireup="true" CodeBehind="Questao3.aspx.cs" Inherits="Porcentagem2017.Questao3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="titulo" runat="server">
</asp:Content>

<asp:Content ID="conteudo" ContentPlaceHolderID="conteudo" runat="server">
    <asp:Label ID="q3" runat="server" Text="Questão 3 -"></asp:Label>
    <strong><%= getPonto() %> pontos</strong>
    <p>Um certo tipo de avião consome, em média, 1.920 litros de combustível apenas para decolar e pousar. Sabendo-se que isso representa 80% de todo combustível que ele gasta em uma viagem entre as cidades A e B, é correto afirmar que o número de litros consumidos numa dessas viagens é:</p>
    <p>Observação: Caso a resposta seja maior ou igual a mil, não é preciso usar ponto como separador de milhar. Exemplo: Use 1000 litros e não 1.000 litros.</p>
    <p>Resposta padrão: 10 litros (um número seguido de espaço e a palavra litros).</p>
    <asp:TextBox ID="txtResp3" runat="server" Font-Size="30pt"></asp:TextBox>
    <p></p>
    <asp:Button ID="btn3_4" runat="server" Text="Ir para questão 4" Font-Size="30pt" OnClick="btn3_4_Click" />
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="rodape" runat="server">
</asp:Content>
