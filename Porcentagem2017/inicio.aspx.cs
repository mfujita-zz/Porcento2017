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
                Response.Redirect("~/AndreaGati.aspx");
            else if (txtRA.Text.Equals("100014636"))
                Response.Redirect("~/AndreaLeoni.aspx");
            else if (txtRA.Text.Equals("170000759"))
                Response.Redirect("~/Andreza.aspx");
            else if (txtRA.Text.Equals("170001326"))
                Response.Redirect("~/Camila");
            else if (txtRA.Text.Equals("170004245"))
                Response.Redirect("~/Caroline.aspx");
            else if (txtRA.Text.Equals("170000758"))
                Response.Redirect("~/EduardoLima.aspx");
            else if (txtRA.Text.Equals("170000751"))
                Response.Redirect("~/EduardoOliveira.aspx");
            else if (txtRA.Text.Equals("170002730"))
                Response.Redirect("~/Felipe.aspx");
            else if (txtRA.Text.Equals("170003365"))
                Response.Redirect("~/Fernanda.aspx");
            else if (txtRA.Text.Equals("160001073"))
                Response.Redirect("~/Gabriel.aspx");
            else if (txtRA.Text.Equals("150000546"))
                Response.Redirect("~/Gabriele.aspx");
            else if (txtRA.Text.Equals("170004244"))
                Response.Redirect("~/Giovane.aspx");
            else if (txtRA.Text.Equals("160002002"))
                Response.Redirect("~/Gislaine.aspx");
            else if (txtRA.Text.Equals("170001307"))
                Response.Redirect("~/Janaina.aspx");
            else if (txtRA.Text.Equals("170005061"))
                Response.Redirect("~/Larissa.aspx");
            else if (txtRA.Text.Equals("170003695"))
                Response.Redirect("~/Lucas.aspx");
            else if (txtRA.Text.Equals("170000810"))
                Response.Redirect("~/NathaliaForato.aspx");
            else if (txtRA.Text.Equals("170000746"))
                Response.Redirect("~/NathaliaPrajo.aspx");
            else if (txtRA.Text.Equals("170002725"))
                Response.Redirect("~/Paloma.aspx");
            else if (txtRA.Text.Equals("140000587"))
                Response.Redirect("~/Patricia.aspx");
            else if (txtRA.Text.Equals("170000749"))
                Response.Redirect("~/Paula.aspx");
            else if (txtRA.Text.Equals("170000747"))
                Response.Redirect("~/Thais.aspx");
            else if (txtRA.Text.Equals("170000755"))
                Response.Redirect("~/Valeria.aspx");
            else if (txtRA.Text.Equals("170003696"))
                Response.Redirect("~/Victoria.aspx");
        }
    }
}