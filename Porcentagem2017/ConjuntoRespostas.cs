using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Porcentagem2017
{
    public class ConjuntoRespostas
    {
        private List<string> listaRespostas = new List<string>();

        public List<string> getRespostas()
        {
            listaRespostas.Clear();
            listaRespostas.Add("1,0575");
            listaRespostas.Add("0,918");
            listaRespostas.Add("2400 litros");
            listaRespostas.Add("45,71%");
            listaRespostas.Add("375,00");
            return listaRespostas;
        }
    }
}