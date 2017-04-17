using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Porcentagem2017
{
    public partial class inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRA_Click(object sender, EventArgs e)
        {
            if (txtRA.Text.Equals("170000750"))
                Response.Redirect("~/Amanda.aspx?ra=170000750");
            else if (txtRA.Text.Equals("170003331"))
                Response.Redirect("~/AndreaGati.aspx?ra=170003331");
            else if (txtRA.Text.Equals("100014636"))
                Response.Redirect("~/AndreaLeoni.aspx?ra=100014636");
            else if (txtRA.Text.Equals("170000759"))
                Response.Redirect("~/Andreza.aspx?ra=170000759");
            else if (txtRA.Text.Equals("170001326"))
                Response.Redirect("~/Camila.aspx?ra=170001326");
            else if (txtRA.Text.Equals("170004245"))
                Response.Redirect("~/Caroline.aspx?ra=170004245");
            else if (txtRA.Text.Equals("170000758"))
                Response.Redirect("~/EduardoLima.aspx?ra=170000758");
            else if (txtRA.Text.Equals("170000751"))
                Response.Redirect("~/EduardoOliveira.aspx?ra=170000751");
            else if (txtRA.Text.Equals("170002730"))
                Response.Redirect("~/Felipe.aspx?ra=170002730");
            else if (txtRA.Text.Equals("170003365"))
                Response.Redirect("~/Fernanda.aspx?ra=170003365");
            else if (txtRA.Text.Equals("160001073"))
                Response.Redirect("~/Gabriel.aspx?ra=160001073");
            else if (txtRA.Text.Equals("150000546"))
                Response.Redirect("~/Gabriele.aspx?ra=150000546");
            else if (txtRA.Text.Equals("170004244"))
                Response.Redirect("~/Giovane.aspx?ra=170004244");
            else if (txtRA.Text.Equals("160002002"))
                Response.Redirect("~/Gislaine.aspx?ra=160002002");
            else if (txtRA.Text.Equals("170001307"))
                Response.Redirect("~/Janaina.aspx?ra=170001307");
            else if (txtRA.Text.Equals("170005061"))
                Response.Redirect("~/Larissa.aspx?ra=170005061");
            else if (txtRA.Text.Equals("170003695"))
                Response.Redirect("~/Lucas.aspx?ra=170003695");
            else if (txtRA.Text.Equals("170000810"))
                Response.Redirect("~/NathaliaForato.aspx?ra=170000810");
            else if (txtRA.Text.Equals("170000746"))
                Response.Redirect("~/NathaliaPrajo.aspx?ra=170000746");
            else if (txtRA.Text.Equals("170002725"))
                Response.Redirect("~/Paloma.aspx?ra=170002725");
            else if (txtRA.Text.Equals("140000587"))
                Response.Redirect("~/Patricia.aspx?ra=140000587");
            else if (txtRA.Text.Equals("170000749"))
                Response.Redirect("~/Paula.aspx?ra=170000749");
            else if (txtRA.Text.Equals("170000747"))
                Response.Redirect("~/Thais.aspx?ra=170000747");
            else if (txtRA.Text.Equals("170000755"))
                Response.Redirect("~/Valeria.aspx?ra=170000755");
            else if (txtRA.Text.Equals("170003696"))
                Response.Redirect("~/Victoria.aspx?ra=170003696");
        }
    }
}