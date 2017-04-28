using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoCalculadoraEmpleado.Models
{
    public class Administrativo : Empleado
    {
        private double SueldoFijo = 500;
        public double Incentivo { get; set; }

        public override double calcularSalario()
        {
            return SueldoFijo + Incentivo;
        }
    }
}