using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CasaFonteDeLuz
{
    public partial class Listagem : System.Web.UI.Page
    {
        struct Afilhado
        {
            public string IdAfilhado { get; set; }
            public bool Apadrinhado { get; set; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var dt = Utils.DatabaseHelper.ExecuteDataTable(new List<KeyValuePair<string, object>>(), "procAfilhadoAdocao_Ler");
            List<Afilhado> afilhados = new List<Afilhado>();

            int i = 0;
            foreach (System.Data.DataRow r in dt.Rows)
            {
                afilhados.Add(
                    new Afilhado()
                    {
                        IdAfilhado = r[0].ToString().Replace(" ", string.Empty),
                        Apadrinhado = Convert.ToBoolean(r[1])
                    });
            }

            RepeaterCriancas.DataSource = afilhados;
            RepeaterCriancas.DataBind();
        }
    }
}