<%@ Page Title="" Language="C#" MasterPageFile="~/Estrutura.Master" AutoEventWireup="true" CodeBehind="Resultados.aspx.cs" Inherits="Porcentagem2017.Resultados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="titulo" ContentPlaceHolderID="titulo" runat="server">
</asp:Content>

<asp:Content ID="ContentPlaceHolder2" ContentPlaceHolderID="conteudo" runat="server">
    <asp:Label ID="exibicao" runat="server" Text="Resultados dos exercícios"></asp:Label>
    <p>RA <%= getRA() %> </p>
    <asp:PlaceHolder ID="conteudo" runat="server"></asp:PlaceHolder>
    <p></p>
        <%--<asp:Table ID="tabela1" runat="server" Font-Size="Larger" BorderWidth="1" Width="100%" GridLines="Both" BorderStyle="Solid" CellPadding="4">
            <asp:TableHeaderRow runat="server" Font-Bold="true">
                <asp:TableCell>#</asp:TableCell>
            </asp:TableHeaderRow>
            <asp:tableHeaderRow runat="server">
                <asp:TableCell>1</asp:TableCell>
            </asp:tableHeaderRow>
            <asp:TableHeaderRow>
                <asp:TableCell>2</asp:TableCell>
            </asp:TableHeaderRow>
            <asp:TableHeaderRow>
                <asp:TableCell>3</asp:TableCell>
            </asp:TableHeaderRow>
                <asp:TableHeaderRow>
                <asp:TableCell>4</asp:TableCell>
            </asp:TableHeaderRow>
                <asp:TableHeaderRow>
                <asp:TableCell>5</asp:TableCell>
            </asp:TableHeaderRow>
        </asp:Table>--%>
</asp:Content>

<asp:Content ID="rodape" ContentPlaceHolderID="rodape" runat="server">
</asp:Content>
