﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Listagem.aspx.cs" Inherits="CasaFonteDeLuz.Listagem" %>

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
                <h3>Nossas crian&ccedil;as TESTE</h3>
                <p>Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore </p>
            </div>

            <asp:Repeater runat="server" ID="RepeaterCriancas">
                <ItemTemplate>
                    <uc:ucAfilhadoMini runat="server" ID="ucAfilhadoMiniUserControl" IdAfilhado='<%# DataBinder.Eval(Container, "DataItem.IdAfilhado") %>' Indice="<%# (Convert.ToInt32( Container.ItemIndex) +1).ToString() %>" />
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>


    <hr />
    <!--gallery-Ends-Here-->
    <div class="products">
        <div class="container">
            <div class="products-top">
                <h3>Nossas crian&ccedil;as</h3>
                <p>Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore </p>
            </div>
            <div class="products-bottom">
                <div class="col-md-4">
                    <div class="view view-tenth">
                        <a href="Adocao.aspx?IdAfilhado=123">
                            <div class="inner_content clearfix">
                                <div class="product_image">
                                    <img src="images/g1.jpg" class="img-responsive of-my" alt="" />
                                    <div class="mask">
                                        <h4>exerci tation ullamcorper suscipit</h4>
                                        <p>A wonderful serenity has taken possession of my entire soul exerci tation ullamcorper suscipit</p>
                                    </div>
                                </div>
                            </div>
                        </a>
                    </div>
                </div>

                <div class="col-md-4">
                    <div class="view view-tenth">
                        <a href="Adocao.aspx">
                            <div class="inner_content clearfix">
                                <div class="product_image">
                                    <img src="images/g2.jpg" class="img-responsive of-my" alt="" />
                                    <div class="mask">
                                        <h4>exerci tation ullamcorper suscipit</h4>
                                        <p>A wonderful serenity has taken possession of my entire soul exerci tation ullamcorper suscipit</p>
                                    </div>
                                </div>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="view view-tenth">
                        <a href="Adocao.aspx?Id=123">
                            <div class="inner_content clearfix">
                                <div class="product_image">
                                    <img src="images/g3.jpg" class="img-responsive of-my" alt="" />
                                    <div class="mask">
                                        <h4>exerci tation ullamcorper suscipit</h4>
                                        <p>
                                            A wonderful serenity has taken possession of my entire soul exerci tation ullamcorper suscipit
                                        </p>
                                    </div>
                                </div>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="clearfix"></div>
            </div>



            <div class="products-bottom">
                <div class="col-md-4">
                    <div class="view view-tenth">
                        <a href="Adocao.aspx">
                            <div class="inner_content clearfix">
                                <div class="product_image">
                                    <img src="images/g4.jpg" class="img-responsive of-my" alt="" />
                                    <div class="mask">
                                        <h4>exerci tation ullamcorper suscipit</h4>
                                        <p>A wonderful serenity has taken possession of my entire soul exerci tation ullamcorper suscipit</p>
                                    </div>
                                </div>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="view view-tenth">
                        <a href="Adocao.aspx">
                            <div class="inner_content clearfix">
                                <div class="product_image">
                                    <img src="images/g5.jpg" class="img-responsive of-my" alt="" />
                                    <div class="mask">
                                        <h4>exerci tation ullamcorper suscipit</h4>
                                        <p>A wonderful serenity has taken possession of my entire soul exerci tation ullamcorper suscipit</p>
                                    </div>
                                </div>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="view view-tenth">
                        <a href="Adocao.aspx">
                            <div class="inner_content clearfix">
                                <div class="product_image">
                                    <img src="images/g6.jpg" class="img-responsive of-my" alt="" />
                                    <div class="mask">
                                        <h4>exerci tation ullamcorper suscipit</h4>
                                        <p>A wonderful serenity has taken possession of my entire soul exerci tation ullamcorper suscipit</p>
                                    </div>
                                </div>
                            </div>
                        </a>
                    </div>
                </div>

                <div class="clearfix"></div>
            </div>
            <div class="products-bottom">
                <div class="col-md-4">
                    <div class="view view-tenth">
                        <a href="Adocao.aspx">
                            <div class="inner_content clearfix">
                                <div class="product_image">
                                    <img src="images/g7.jpg" class="img-responsive of-my" alt="" />
                                    <div class="mask">
                                        <h4>exerci tation ullamcorper suscipit</h4>
                                        <p>A wonderful serenity has taken possession of my entire soul exerci tation ullamcorper suscipit</p>
                                    </div>
                                </div>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="view view-tenth">
                        <a href="Adocao.aspx">
                            <div class="inner_content clearfix">
                                <div class="product_image">
                                    <img src="images/g8.jpg" class="img-responsive of-my" alt="" />
                                    <div class="mask">
                                        <h4>exerci tation ullamcorper suscipit</h4>
                                        <p>A wonderful serenity has taken possession of my entire soul exerci tation ullamcorper suscipit</p>
                                    </div>
                                </div>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="view view-tenth">
                        <a href="Adocao.aspx">
                            <div class="inner_content clearfix">
                                <div class="product_image">
                                    <img src="images/g9.jpg" class="img-responsive of-my" alt="" />
                                    <div class="mask">
                                        <h4>exerci tation ullamcorper suscipit</h4>
                                        <p>A wonderful serenity has taken possession of my entire soul exerci tation ullamcorper suscipit</p>
                                    </div>
                                </div>
                            </div>
                        </a>
                    </div>
                </div>

                <div class="clearfix"></div>
            </div>
        </div>
    </div>
    <!--gallery-Ends-Here-->
</asp:Content>
