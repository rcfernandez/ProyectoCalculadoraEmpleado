using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoCalculadoraEmpleado.Models
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double Sueldo { get; set; }

        public abstract double calcularSalario();

    }
}