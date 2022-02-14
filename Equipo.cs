using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campeonato
{
    internal class Equipo
    {
        private string nom_equipo;
        private int[] players = new int[22];

        public Equipo(string n_equipo, int[] spielers)
        {
            nom_equipo = n_equipo;
            spielers = players;
        }
        public string Nom_equipo
        {
            get { return nom_equipo; }
            set { nom_equipo = value; }
        }

        
    }
}
