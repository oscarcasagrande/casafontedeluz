<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Adocao.aspx.cs" Inherits="CasaFonteDeLuz.Adocao" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderMenu" runat="server">
    <div class="navigation">
        <ul class="navig">
            <li><a href="Default.aspx">Home</a></li>
            <li><a href="#">Quem somos</a></li>
            <li><a href="#">O que fazemos</a></li>
            <li class="active"><a href="Listagem.aspx">Adote</a></li>
            <li><a href="#">Contato</a></li>
        </ul>
    </div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!--gallery-Ends-Here-->
    <div class="products">
        <div class="container">
            <div class="products-top">
                <h3>Ado&ccedil;&atilde;o</h3>
                <!--start-contact-->
                <div class="contact">
                    <div class="container">
                        <div class="contact-main">
                            <div class="contact-text">
                                <div class="col-md-6 contact-left-text">
                                    <asp:TextBox ID="EmailPadrinhoTextbox" runat="server"></asp:TextBox>
                                    <asp:TextBox ID="NomePadrinhoTextbox" runat="server"></asp:TextBox>
                                    <asp:TextBox ID="TelefonePadrinhoTextbox" runat="server"></asp:TextBox>
                                </div>
                                <div class="col-md-6 contact-left-text">
                                    <asp:TextBox ID="MensagemPadrinhoTextbox" TextMode="MultiLine" runat="server" Text="Mensagem..."></asp:TextBox>
                                </div>
                                <div class="clearfix"></div>
                                <div class="contact-but">
                                    <asp:Button ID="SubmitButton" runat="server" Text="Enviar" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!--end-contact-->
            </div>
        </div>
    </div>
</asp:Content>
