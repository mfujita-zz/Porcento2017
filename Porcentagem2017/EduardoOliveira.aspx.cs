using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Porcentagem2017
{
    public partial class EduardoOliveira : System.Web.UI.Page
    {
        private string ra;
        protected void Page_Load(object sender, EventArgs e)
        {
            ra = Request.QueryString["ra"];
        }

        protected void confirmar_Click(object sender, EventArgs e)
        {
            DateTime agora = DateTime.Now;
            Response.Redirect("~/Questao1.aspx?ra=" + ra + "&tempo=" + agora);
        }
    }
}