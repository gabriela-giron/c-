using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campeonato
{
    internal class Torneo
    {
        private string torneos;
        private int[] teams = new int[20];

        public Torneo(string nom_torneo, int[] equipos)
        {
            torneos = nom_torneo;
            equipos = teams;
        }

        public string Torneos
        {
            get { return torneos ; }
            set { torneos = value; }
        }
        public int[] Teams 
        {
            get { return teams; }
            set { teams = value; }
        }

    }
}
