<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AfilhadoMiniWebUserControl.ascx.cs" Inherits="CasaFonteDeLuz.webusercontrol.AfilhadoMiniWebUserControl" %>
<%
    if (this.FazQuebra) { Response.Write(@"<div class=""products-bottom"">"); }
%>
<div class="col-md-4" x="<%=this.Indice %>">
    <div class="view <% if (!this.Apadrinhado) { Response.Write(" view-tenth"); } %>">
        <%if (this.Apadrinhado == false)
            {%>
        <a href="Adocao.aspx?IdAfilhado=<%# this.IdAfilhado %>">
            <%
                } %>

            <div class="inner_content clearfix">
                <div class="product_image">
                    <img src="images/afilhados/<%# this.IdAfilhado %>.JPG" class="img-responsive of-my" alt="" />
                    <div class="mask">
                        <%
                            if (this.Apadrinhado == false)
                            {
                        %>
                        <h4>exerci tation ullamcorper suscipit</h4>
                        <%
                            }
                            else
                            {
                        %>
                        <h4>Apadrinhado!</h4>
                        <%
                            }
                        %>
                        <p>A wonderful serenity has taken possession of my entire soul exerci tation ullamcorper suscipit</p>
                    </div>
                </div>
            </div>
        </a>
    </div>
</div>
<%
    if (this.FazQuebra && this.Indice > 1) { Response.Write(@"<div class=""clearfix"" /></div>"); }
%>
