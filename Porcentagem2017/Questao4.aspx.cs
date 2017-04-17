using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Porcentagem2017
{
    public partial class Questao4 : System.Web.UI.Page
    {
        private int ponto;
        private string ra;
        private DateTime agora;

        protected void Page_Load(object sender, EventArgs e)
        {
            ponto = 3;
            ra = Request.QueryString["ra"];
            agora = Convert.ToDateTime(Request.QueryString["tempo"].ToString());
        }

        public int getPontos()
        {
            return ponto;
        }

        protected void btn4_5_Click(object sender, EventArgs e)
        {
            ManipulaTempo mt = new ManipulaTempo(agora);
            ConjuntoRespostas cr = new ConjuntoRespostas();

            using (SqlConnection con = new SqlConnection("Server=SAMSUNG-SERIE-9\\SQLEXPRESS; Database=gincana; Trusted_Connection=True;"))
            {
                using (SqlCommand cmd = new SqlCommand("insert into Tporcentagem (num_questao, respAluno, gabarito, pontuacao, ra_jogador, duracao) values (@NUM_QUESTAO, @RESPALUNO, @GABARITO, @PONTUACAO, @RA_JOGADOR, @DURACAO)", con))
                {
                    cmd.Parameters.AddWithValue("NUM_QUESTAO", "4");
                    cmd.Parameters.AddWithValue("RESPALUNO", txtResp4.Text.Trim());
                    cmd.Parameters.AddWithValue("GABARITO", cr.getRespostas()[3]);
                    if (txtResp4.Text.Trim().Equals(cr.getRespostas()[3]))
                        cmd.Parameters.AddWithValue("PONTUACAO", ponto);
                    else
                        cmd.Parameters.AddWithValue("PONTUACAO", 0);
                    cmd.Parameters.AddWithValue("RA_JOGADOR", ra);
                    cmd.Parameters.AddWithValue("DURACAO", mt.DuracaoRaciocinio());
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Response.Redirect("~/Questao5.aspx?ra=" + ra + "&tempo=" + mt.getDepois());
                }
            }
        }
    }
}