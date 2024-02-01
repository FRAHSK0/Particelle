using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particelle
{
    internal class Particella
    {
        int posizione;
        public Particella(int posizione)
        {
            this.posizione = posizione;



        }
        public int Posizione
        { 
        get=>posizione; 
        set=>this.posizione = value;
        }

    }
}
