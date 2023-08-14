using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.JuegoCartas
{
    public class CartaEspecial : Carta
    {

        public string Efecto { get; }

        public CartaEspecial(int valor, string palo, string efecto) : base(valor, palo)
        {
            Efecto = efecto;
        }

        public override bool SePuedeJugar(Carta anterior)
        {
            return true;
        }

        public void AplicarEfecto()
        {
            Console.WriteLine($"Aplicando efecto: {Efecto}");
        }
    }
}
