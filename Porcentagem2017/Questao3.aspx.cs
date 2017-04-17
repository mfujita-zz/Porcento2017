using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Porcentagem2017
{
    public partial class Questao3 : System.Web.UI.Page
    {
        string ra;
        private int pontos;
        DateTime agora;

        protected void Page_Load(object sender, EventArgs e)
        {
            pontos = 2;
            ra = Request.QueryString["ra"];
            agora = Convert.ToDateTime(Request.QueryString["tempo"].ToString());
        }

        public int getPonto()
        {
            return pontos;
        }

        protected void btn3_4_Click(object sender, EventArgs e)
        {
            ManipulaTempo mt = new ManipulaTempo(agora);
            ConjuntoRespostas cr = new ConjuntoRespostas();

            using (SqlConnection con = new SqlConnection("Server=SAMSUNG-SERIE-9\\SQLEXPRESS; Database=gincana; Trusted_Connection=True;"))
            {
                using (SqlCommand cmd = new SqlCommand("insert into Tporcentagem (respAluno, gabarito, pontuacao, ra_jogador, duracao) values (@RESPALUNO, @GABARITO, @PONTUACAO, @RA_JOGADOR, @DURACAO)", con))
                {
                    cmd.Parameters.AddWithValue("RESPALUNO", txtResp3.Text.Trim());
                    cmd.Parameters.AddWithValue("GABARITO", cr.getRespostas()[2]);
                    if (txtResp3.Text.Trim().Equals(cr.getRespostas()[2]))
                        cmd.Parameters.AddWithValue("PONTUACAO", pontos);
                    else
                        cmd.Parameters.AddWithValue("PONTUACAO", 0);
                    cmd.Parameters.AddWithValue("RA_JOGADOR", ra);
                    cmd.Parameters.AddWithValue("DURACAO", mt.DuracaoRaciocinio());
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Response.Redirect("~/Questao4.aspx?ra=" + ra + "&tempo=" + mt.getDepois());
                }
            }
        }
    }
}