using System;

namespace Taller2.GestionEmpleados
{
    public class Desarrollador : Empleado
    {
        public string Lenguaje { get; set; }

        public Desarrollador(string nombre, decimal salario, int numeroIdentificacion, string lenguaje)
            : base(nombre, salario, numeroIdentificacion)
        {
            Lenguaje = lenguaje;
        }

        public string ObtenerDescripcion()
        {
            return $"{Nombre} es un desarrollador que trabaja con {Lenguaje}";
        }

        public override decimal CalcularSalario()
        {
            // Lógica de cálculo de salario específica para desarrolladores
            // Por ejemplo, basado en líneas de código escritas u otros criterios
            return Salario + (Salario * 0.1M); // Ejemplo de aumento del 10%
        }

        public void EscribirCodigo(string tarea)
        {
            Console.WriteLine($"El desarrollador {Nombre} está escribiendo código para la tarea: {tarea}");
        }

        public void SolicitarSoporteTecnico(string problema)
        {
            Console.WriteLine($"El desarrollador {Nombre} ha solicitado soporte técnico para el problema: {problema}");
        }
    }
}
