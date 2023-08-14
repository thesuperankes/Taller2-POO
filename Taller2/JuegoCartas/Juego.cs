using System;
using System.Collections.Generic;

namespace Taller2.JuegoCartas
{
    public class Juego
    {
        private Carta Previa { get; set; }

        public List<Carta> CrearMazo()
        {
            List<Carta> mazo = new List<Carta>();

            // Agregar cartas normales
            CrearCartasNormales(mazo);

            // Agregar cartas especiales
            mazo.Add(new CartaEspecial(4, "+4", "Se añaden 4 cartas a la mano del otro jugador"));

            return mazo;
        }

        private void CrearCartasNormales(List<Carta> mazo)
        {
            foreach (Color color in Enum.GetValues(typeof(Color)))
            {
                for (int valor = 1; valor <= 9; valor++)
                {
                    mazo.Add(new CartaNormal(valor, color.ToString()));
                }
            }
        }

        public List<Carta> RepartirCartas(List<Carta> mazo, int cantidad)
        {
            Random rand = new Random();
            List<Carta> mano = new List<Carta>();

            for (int i = 0; i < cantidad; i++)
            {
                int index = rand.Next(mazo.Count);
                mano.Add(mazo[index]);
                mazo.RemoveAt(index);
            }

            return mano;
        }

        public void MostrarCartas(List<Carta> mano)
        {
            foreach (var carta in mano)
            {
                Console.WriteLine($"[{mano.IndexOf(carta)}] {carta.Valor} de {carta.Palo}");
            }
        }

        private int SeleccionarIndiceCarta(List<Carta> mano)
        {
            Console.WriteLine("Elige una carta para jugar (ingresa el número de índice):");
            int indice;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out indice) && indice >= 0 && indice < mano.Count)
                {
                    break;
                }
                Console.WriteLine("Índice inválido. Introduce un número válido.");
            }

            return indice;
        }

        public Carta JugarCarta(List<Carta> mano)
        {
            int indice = SeleccionarIndiceCarta(mano);
            Carta cartaJugada = mano[indice];

            if (Previa == null)
            {
                Previa = cartaJugada;
            }
            else
            {
                bool puedeJugar = cartaJugada.SePuedeJugar(Previa);

                if (!puedeJugar)
                {
                    Console.WriteLine("No se puede jugar esa carta");
                    return JugarCarta(mano);
                }
                else
                {
                    mano.RemoveAt(indice);
                    Previa = cartaJugada;
                }
            }

            if (cartaJugada is CartaEspecial cartaEspecial)
            {
                cartaEspecial.AplicarEfecto();
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }

            return cartaJugada;
        }

    }

    public enum Color
    {
        Rojo,
        Verde,
        Amarillo,
        Azul
    }

}
