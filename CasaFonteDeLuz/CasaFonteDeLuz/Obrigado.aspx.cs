using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CasaFonteDeLuz
{
    public partial class Obrigado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["IdAfilhado"] != null)
            {
                ImageAfilhado.Src = string.Format("images/afilhados/{0}.jpg", Request.QueryString["IdAfilhado"].ToString());
            }

        }
    }
}