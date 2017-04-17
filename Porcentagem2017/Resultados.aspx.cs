using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Porcentagem2017
{
    public partial class Resultados : System.Web.UI.Page
    {
        private string ra;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = GetData();
                StringBuilder html = new StringBuilder();

                html.Append("<table border=1>");
                html.Append("<tr>");
                html.Append("<th>Sua resposta</th><th>Pontuação</th><th>Tempo da sua solução</th>");
                html.Append("</tr>");

                foreach (DataRow linha in dt.Rows)
                {
                    html.Append("<tr>");
                    foreach (DataColumn coluna in dt.Columns)
                    {
                        html.Append("<td>");
                        html.Append(linha[coluna.ColumnName]);
                    }
                    html.Append("</tr>");
                }

                html.Append("</table>");
                conteudo.Controls.Add(new Literal { Text = html.ToString() });
            }
        }

        private DataTable GetData()
        {
            ra = Request.QueryString["ra"].ToString();

            using (SqlConnection con = new SqlConnection("Server=SAMSUNG-SERIE-9\\SQLEXPRESS; Database=gincana; Trusted_Connection=True;"))
            {
                using (SqlCommand cmd = new SqlCommand("select respAluno as Resposta, pontuacao, duracao as Tempo from Tporcentagem where ra_jogador = " + ra, con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        public string getRA()
        {
            return ra;
        }
    }
}