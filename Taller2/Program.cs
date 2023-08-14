using System;
using System.Collections.Generic;
using System.Security.Policy;
using Taller2.GestionEmpleados;
using Taller2.JuegoCartas;

namespace Taller2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JuegoCartas();
            //GestionEmpleados();


            Console.ReadKey();
        }

        public static void JuegoCartas()
        {
            bool turnoPrimer = false;
            Juego juego = new Juego();
            List<Carta> mazo = juego.CrearMazo();
            Carta cartaJugada = null;

            Console.WriteLine("Bienvenido al juego de UNO!");
            Console.WriteLine("Presiona Enter para repartir cartas...");
            Console.ReadLine();

            List<Carta> manoJugador = juego.RepartirCartas(mazo, 7);
            List<Carta> manoJugador2 = juego.RepartirCartas(mazo, 7);

            while (true)
            {
                Console.Clear();
                turnoPrimer = !turnoPrimer;
                if(cartaJugada != null)
                    Console.WriteLine($"Carta jugada: {cartaJugada.Valor} de {cartaJugada.Palo}");


                if (turnoPrimer)
                {
                    Console.WriteLine("Turno jugador 1");
                    juego.MostrarCartas(manoJugador);

                    cartaJugada = juego.JugarCarta(manoJugador);
                }
                else
                {
                    Console.WriteLine("Turno jugador 2");
                    juego.MostrarCartas(manoJugador2);

                    cartaJugada = juego.JugarCarta(manoJugador2);
                }

                Console.WriteLine($"Has jugado: {cartaJugada.Valor} de {cartaJugada.Palo}");
            }
        }

        public static void GestionEmpleados()
        {
            Console.WriteLine("Bienvenido al Sistema de Gestión de Empleados");

            // Ingresar datos del gerente
            Console.Write("Ingrese el nombre del gerente: ");
            string nombreGerente = Console.ReadLine();
            Console.Write("Ingrese el salario del gerente: ");
            decimal salarioGerente = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Ingrese el número de identificación del gerente: ");
            int numIdGerente = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el bono del gerente: ");
            decimal bonoGerente = Convert.ToDecimal(Console.ReadLine());

            Gerente gerente = new Gerente(nombreGerente, salarioGerente, numIdGerente, bonoGerente);

            // Ingresar datos del desarrollador
            Console.Write("Ingrese el nombre del desarrollador: ");
            string nombreDesarrollador = Console.ReadLine();
            Console.Write("Ingrese el salario del desarrollador: ");
            decimal salarioDesarrollador = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Ingrese el número de identificación del desarrollador: ");
            int numIdDesarrollador = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el lenguaje de programación del desarrollador: ");
            string lenguajeDesarrollador = Console.ReadLine();

            Desarrollador desarrollador = new Desarrollador(nombreDesarrollador, salarioDesarrollador, numIdDesarrollador, lenguajeDesarrollador);

            // Mostrar detalles de los empleados
            Console.WriteLine("\nDetalles del Gerente:");
            Console.WriteLine($"Nombre: {gerente.Nombre}");
            Console.WriteLine($"Salario: {gerente.CalcularSalario()}");
            Console.WriteLine($"Número de Identificación: {gerente.NumeroIdentificacion}");

            gerente.RealizarRevisionMensual(); // Simulación de revisión mensual
            gerente.AprobarVacaciones(10); // Simulación de aprobación de vacaciones


            Console.WriteLine("\nDetalles del Desarrollador:");
            Console.WriteLine($"Nombre: {desarrollador.Nombre}");
            Console.WriteLine($"Salario: {desarrollador.CalcularSalario()}");
            Console.WriteLine($"Número de Identificación: {desarrollador.NumeroIdentificacion}");
            Console.WriteLine($"Lenguaje de Programación: {desarrollador.Lenguaje}");
            Console.WriteLine($"Descripción: {desarrollador.ObtenerDescripcion()}");

            desarrollador.EscribirCodigo("Nueva funcionalidad"); // Simulación de escribir código
            desarrollador.SolicitarSoporteTecnico("Error en compilación"); // Simulación de solicitud de soporte técnico
        }
    }
}
