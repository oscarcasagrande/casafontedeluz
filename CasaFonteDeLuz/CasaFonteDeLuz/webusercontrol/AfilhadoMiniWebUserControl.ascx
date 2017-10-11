<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AfilhadoMiniWebUserControl.ascx.cs" Inherits="CasaFonteDeLuz.webusercontrol.AfilhadoMiniWebUserControl" %>
<%

    if (Convert.ToInt32(this.Indice) % 3 == 0 || Convert.ToInt32(this.Indice) == 0)
    {
%>
<div class="products-bottom">
    <%
        } %>
    <div class="col-md-4">
        <div class="view view-tenth">
            <a href="Adocao.aspx?IdAfilhado=<%# this.IdAfilhado %>">
                <div class="inner_content clearfix">
                    <div class="product_image">
                        <img src="images/afilhados/<%# this.IdAfilhado %>.JPG" class="img-responsive of-my" alt="" />
                        <div class="mask">
                            <h4>exerci tation ullamcorper suscipit</h4>
                            <p>A wonderful serenity has taken possession of my entire soul exerci tation ullamcorper suscipit</p>
                        </div>
                    </div>
                </div>
            </a>
        </div>
    </div>
    <%
        if (Convert.ToInt32(this.Indice) % 3 == 0 || Convert.ToInt32(this.Indice) == 0)
        {
    %>
    <div class="clearfix" />
</div>
<%
    }
%>
