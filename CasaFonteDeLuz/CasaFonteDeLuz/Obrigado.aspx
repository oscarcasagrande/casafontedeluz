<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Obrigado.aspx.cs" Inherits="CasaFonteDeLuz.Obrigado" %>

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
    <div class="products">
        <div class="container">
            <div class="products-top">
                <h3>Obrigado ;)</h3>
                <p>A sua doação é de extrema importância para essa criança!</p>
                <div class="col-md-4">
                    <div class="view">
                        <div class="inner_content clearfix">
                            <div class="product_image">
                                <img src="images/afilhados/<%=Request.QueryString["IdAfilhado"].ToString(); %>.JPG" class="img-responsive of-my" alt="" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
