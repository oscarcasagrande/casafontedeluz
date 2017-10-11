<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Listagem.aspx.cs" Inherits="CasaFonteDeLuz.Listagem" %>

<%@ Register TagPrefix="uc" TagName="ucAfilhadoMini" Src="~/webusercontrol/AfilhadoMiniWebUserControl.ascx" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderMenu" runat="server">
    <div class="navigation">
        <ul class="navig">
            <li><a href="Default.aspx">Home</a></li>
            <li><a href="#">Quem somos</a></li>
            <li><a href="#">Nosso trabalho</a></li>
            <li class="active"><a href="Listagem.aspx">Adote</a></li>
            <li><a href="#">Contato</a></li>
        </ul>
    </div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="products">
        <div class="container">
            <div class="products-top">
                <h3>Nossas crian&ccedil;as</h3>
                <p>Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore </p>
            </div>

            <asp:Repeater runat="server" ID="RepeaterCriancas">
                <ItemTemplate>
                    <uc:ucAfilhadoMini
                        runat="server"
                        ID="ucAfilhadoMiniUserControl"
                        IdAfilhado='<%# DataBinder.Eval(Container, "DataItem.IdAfilhado") %>'
                        Indice='<%# DataBinder.Eval(Container, "DataItem.Indice")  %>'
                        Apadrinhado='<%# DataBinder.Eval(Container, "DataItem.Apadrinhado") %>' />
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
