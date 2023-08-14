using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.JuegoCartas
{
    public class CartaNormal : Carta
    {
        public CartaNormal(int valor, string palo) : base(valor, palo)
        {
        }

        public override bool SePuedeJugar(Carta anterior)
        {
            return anterior.Palo == Palo || anterior.Valor == Valor;
        }

    }
}
