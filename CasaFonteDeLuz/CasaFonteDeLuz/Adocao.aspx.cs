using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CasaFonteDeLuz
{
    public partial class Adocao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string idAfilhado = string.Empty;
            string emailPadrinho = string.Empty;
            string nomePadrinho = string.Empty;
            string mensagemPadrinho = string.Empty;
            string telefonePadrinho = string.Empty;


            NomePadrinhoTextbox.Attributes.Add("value", "Nome");
            NomePadrinhoTextbox.Attributes.Add("onfocus", "this.value = '';");
            NomePadrinhoTextbox.Attributes.Add("onblur", "if (this.value == '') {this.value = 'Nome';}");

            EmailPadrinhoTextbox.Attributes.Add("value", "Email");
            EmailPadrinhoTextbox.Attributes.Add("onfocus", "this.value = '';");
            EmailPadrinhoTextbox.Attributes.Add("onblur", "if (this.value == '') {this.value = 'Email';}");



            TelefonePadrinhoTextbox.Attributes.Add("value", "Telefone");
            TelefonePadrinhoTextbox.Attributes.Add("onfocus", "this.value = '';");
            TelefonePadrinhoTextbox.Attributes.Add("onblur", "if (this.value == '') {this.value = 'Telefone';}");

            MensagemPadrinhoTextbox.Attributes.Add("onfocus", "this.value = '';");
            MensagemPadrinhoTextbox.Attributes.Add("onblur", "if (this.value == '') {this.value = 'Mensagem';}");



            if (Page.IsPostBack == true)
            {
                if (Request.QueryString["IdAfilhado"] != null)
                {
                    idAfilhado = Request.QueryString["IdAfilhado"].ToString();
                }

                if (Request.Form["ctl00$ContentPlaceHolder1$EmailPadrinhoTextbox"] != null)
                {
                    emailPadrinho = Request.Form["ctl00$ContentPlaceHolder1$EmailPadrinhoTextbox"].ToString();
                }

                if (Request.Form["ctl00$ContentPlaceHolder1$NomePadrinhoTextbox"] != null)
                {
                    nomePadrinho = Request.Form["ctl00$ContentPlaceHolder1$NomePadrinhoTextbox"].ToString();
                }

                if (Request.Form["ctl00$ContentPlaceHolder1$MensagemPadrinhoTextbox"] != null)
                {
                    mensagemPadrinho = Request.Form["ctl00$ContentPlaceHolder1$MensagemPadrinhoTextbox"].ToString();
                }

                if (Request.Form["ctl00$ContentPlaceHolder1$TelefonePadrinhoTextbox"] != null)
                {
                    telefonePadrinho = Request.Form["ctl00$ContentPlaceHolder1$TelefonePadrinhoTextbox"].ToString();
                }




                List<KeyValuePair<string, object>> parameters = new List<KeyValuePair<string, object>>();
                parameters.Add(new KeyValuePair<string, object>("@idAfilhado", idAfilhado));

                bool afilhadoComPadrinho = (bool)Utils.DatabaseHelper.ExecuteReader(parameters, "procAdocaoIdAfilhado_Ler").Read();

                if (afilhadoComPadrinho == false)
                {
                    parameters.Clear();

                    parameters.Add(new KeyValuePair<string, object>("@IdAfilhado", idAfilhado));
                    parameters.Add(new KeyValuePair<string, object>("@emailPadrinho", emailPadrinho));
                    parameters.Add(new KeyValuePair<string, object>("@nomePadrinho", nomePadrinho));
                    parameters.Add(new KeyValuePair<string, object>("@comentarioPadrinho", mensagemPadrinho));
                    parameters.Add(new KeyValuePair<string, object>("@telefonePadrinho", telefonePadrinho));


                    bool resultado = false;
                    try
                    {
                        Utils.DatabaseHelper.ExecuteScalar(parameters, "procAdocao_Criar", null);
                        resultado = true;
                    }
                    catch (Exception)
                    {

                    }

                    if (resultado == true)
                    {
                        Response.Redirect(
                            string.Format("Obrigado.aspx?IdAfilhado={0}", idAfilhado));
                    }
                    else
                    {
                        // to do: habilitar retorno para selecionar outro afilhado
                    }
                }
                else
                {
                    Response.Redirect("Listagem.aspx");
                }

            }
        }
    }
}