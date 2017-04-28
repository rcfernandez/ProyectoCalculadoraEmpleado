using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoCalculadoraEmpleado.Models
{
    public class Programador : Empleado
    {
        private double ValorHora = 45;
        private double Incentivo = 200;
        public int CantidadHoras { get; set; }

        public override double calcularSalario()
        {
            return (ValorHora * CantidadHoras) + Incentivo;
        }

    }
}