using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.GestionEmpleados
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public decimal Salario { get; set; }
        public int NumeroIdentificacion { get; set; }

        public Empleado(string nombre, decimal salario, int numeroIdentificacion)
        {
            Nombre = nombre;
            Salario = salario;
            NumeroIdentificacion = numeroIdentificacion;
        }

        public virtual decimal CalcularSalario()
        {
            return Salario;
        }

        public void AprobarVacaciones(int dias)
        {
            Console.WriteLine($"Vacaciones aprobadas para {dias} días para el gerente {Nombre}");
        }

        public void RealizarRevisionMensual()
        {
            Console.WriteLine($"Realizando revisión mensual para el gerente {Nombre}");
        }
    }
}
