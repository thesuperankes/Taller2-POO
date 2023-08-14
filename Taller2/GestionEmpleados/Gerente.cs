using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.GestionEmpleados
{
    public class Gerente : Empleado
    {
        public decimal Bono { get; set; }

        public Gerente(string nombre, decimal salario, int numeroIdentificacion, decimal bono)
            : base(nombre, salario, numeroIdentificacion)
        {
            Bono = bono;
        }

        public override decimal CalcularSalario()
        {
            return Salario + Bono;
        }
    }
}
