using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campeonato
{
    internal class Jugador
    {
        private string nombre;
        private int no_camisola;
        int amarillas = 0;
        int rojas = 0;
        int goles = 0;

        public Jugador(string name, int camisola)
        {
            name = nombre;
            camisola = no_camisola;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int NoCamisola
        {
            get { return no_camisola; }
            set { no_camisola = value; }
        }
        public void Gol(int n, string op)
        {
            do
            {
                Console.WriteLine("Ingrese el gol reciente: ");
                goles += n;
                Console.WriteLine("Desea ingresar otro gol? ");
                string op = Console.ReadLine();
            } while (op == 's' || op == 'S');

        }
    }
}
