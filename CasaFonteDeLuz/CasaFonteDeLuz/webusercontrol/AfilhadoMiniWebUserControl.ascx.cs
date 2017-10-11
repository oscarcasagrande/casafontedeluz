using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CasaFonteDeLuz.webusercontrol
{
    public partial class AfilhadoMiniWebUserControl : System.Web.UI.UserControl
    {
        public string IdAfilhado { get; set; }
        public int Indice { get; set; }
        public bool Apadrinhado { get; set; }
        public bool FazQuebra { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
    }
}