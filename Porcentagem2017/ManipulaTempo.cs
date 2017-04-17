using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Porcentagem2017
{
    public class ManipulaTempo
    {
        private DateTime agora;
        private DateTime depois;

        public ManipulaTempo(DateTime _agora)
        {
            agora = _agora;
        }

        public DateTime getDepois()
        {
            return depois;
        }

        public string DuracaoRaciocinio()
        {
            depois = DateTime.Now;
            var diferenca = (depois - agora).TotalSeconds;
            int minutos = Convert.ToInt16(diferenca) / 60;
            int segundos = Convert.ToInt16(diferenca) % 60;
            return minutos + "min" + segundos + "s";
        }
    }
}