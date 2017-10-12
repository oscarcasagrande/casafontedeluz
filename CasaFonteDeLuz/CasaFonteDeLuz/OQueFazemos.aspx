<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="OQueFazemos.aspx.cs" Inherits="CasaFonteDeLuz.OQueFazemos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMenu" runat="server">
    <div class="navigation">
        <ul class="navig">
            <li><a href="Default.aspx">Home</a></li>
            <li><a href="QuemSomos.aspx">Quem somos</a></li>
            <li class="active"><a href="OQueFazemos.aspx">O que fazemos</a></li>
            <li><a href="Listagem.aspx">Adote</a></li>
            <li><a href="Contato.aspx">Contato</a></li>
        </ul>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
