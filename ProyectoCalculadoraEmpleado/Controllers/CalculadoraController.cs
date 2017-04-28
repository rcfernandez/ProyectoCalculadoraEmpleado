using ProyectoCalculadoraEmpleado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoCalculadoraEmpleado.Controllers
{
    public class CalculadoraController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        // formulario programador
        public ActionResult Programador()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Programador(Programador P)
        {
            ViewBag.nombre = P.Nombre;
            ViewBag.apellido = P.Apellido;
            ViewBag.sueldo = P.calcularSalario();

            return View("Resultado");
        }

        // formulario administrativo
        public ActionResult Administrativo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Administrativo(Administrativo A)
        {
            ViewBag.nombre = A.Nombre;
            ViewBag.apellido = A.Apellido;
            ViewBag.sueldo = A.calcularSalario();

            return View("Resultado");
        }

        public ActionResult Resultado()
        {
            return View();
        }
    }
}