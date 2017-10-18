using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            public int Indice { get; set; }
            public bool FazQuebra { get; set; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var dt = Utils.DatabaseHelper.ExecuteDataTable(new List<KeyValuePair<string, object>>(), "procAfilhadoAdocao_Ler");
            List<Afilhado> afilhados = new List<Afilhado>();
            int i = 0;

            StringBuilder x = new StringBuilder();

            foreach (System.Data.DataRow r in dt.Rows)
            {
                i++;

                afilhados.Add(new Afilhado()
                {
                    IdAfilhado = r[0].ToString().Replace(" ", string.Empty),
                    Apadrinhado = Convert.ToBoolean(r[1]),
                    Indice = i,
                    FazQuebra = i % 3 == 0 && i != 0
                });
            }

            RepeaterCriancas.DataSource = afilhados;
            RepeaterCriancas.DataBind();
        }
    }
}