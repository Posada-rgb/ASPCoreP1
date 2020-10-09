using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASPCorePractica1.Models;

namespace ASPCorePractica1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            /*return View();*/
            CanalVideos canalVideos = new CanalVideos();

            /*Declaracion de variables para cada categoria de la clase canal*/
            var a                   =   canalVideos;
            var b                   =   canalVideos;
            var c                   =   canalVideos;

            /*VARIABLE "A" HACE REFERENCIA A SUS CAMPOS CORRESPONDIENTES EN CANALVIDEOS.CS*/ 
            a.IDA                   =   "#001";
            a.Nick_userA            =   "Posada67";
            a.Lista_RepA            =   "Divulgacion cientifica";
            a.CategoriaVid_1A       =   "Documentales";
            a.CategoriaVid_2A       =   "Teorías cuanticas";
            a.CategoriaVid_3A       =   "Teorías espaciales";
            a.Mas_vistoA            =   "El espacio y su infinidad";
            a.Descripcion_canalA    =   "Canal dedicado a la divulgacion";
            a.Fecha_creacionA       =   DateTime.Now;

            /*VARIABLE "B" HACE REFERENCIA A SUS CAMPOS CORRESPONDIENTES EN CANALVIDEOS.CS*/
            b.IDB                   =   "#002";
            b.Nick_userB            =   "Alcachofa23";
            b.Lista_RepB            =   "Matematicas intensivo";
            b.CategoriaVid_1B       =   "Tutoriales Unidad 1 y 2";
            b.CategoriaVid_2B       =   "Tutoriales Unidad 3 y 4";
            b.CategoriaVid_3B       =   "Repaso de unidades";
            b.Mas_vistoB            =   "Calculo vectorial";
            b.Descripcion_canalB    =   "Canal dedicado a enseñanza";
            b.Fecha_creacionB       =   DateTime.Now;

            /*VARIABLE "B" HACE REFERENCIA A SUS CAMPOS CORRESPONDIENTES EN CANALVIDEOS.CS*/
            c.IDC                   =   "#003";
            c.Nick_userC            =   "LDGames";
            c.Lista_RepC            =   "Programación de juegos";
            c.CategoriaVid_1C       =   "Unity";
            c.CategoriaVid_2C       =   "Unreal Engine 4";
            c.CategoriaVid_3C       =   "Solución de bugs";
            c.Mas_vistoC            =   "Crear un juego de disparos";
            c.Descripcion_canalC    =   "Canal dedicado a desarrollo";
            c.Fecha_creacionC       =   DateTime.Now;

            /*RETURN REGRESA TODOS LOS OBJETOS EXISTENTES EN CANALVIDEOS*/
            return View(canalVideos);

        }

        



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
