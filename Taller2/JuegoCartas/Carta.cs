using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.JuegoCartas
{
    public class Carta
    {
        public int Valor { get; }
        public string Palo { get; }

        public Carta(int valor, string palo)
        {
            Valor = valor;
            Palo = palo;
        }

        public virtual bool SePuedeJugar(Carta anterior)
        {
            return false;
        }
    }
}
