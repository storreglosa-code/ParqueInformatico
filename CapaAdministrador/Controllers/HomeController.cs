using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaEntidad;
using CapaDatos;
using CapaNegocios;

namespace CapaAdministrador.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult ListarDependencias()
        {
            List<Dependencia> oLista = new List<Dependencia>();

            oLista = new CN_Dependencia().Listar();
                
                

            return Json(new {data = oLista.Where(x=>x.Edificio) } , JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult ListarDependenciasDGA()
        {
            List<Dependencia> oLista = new List<Dependencia>();

            oLista = new CN_Dependencia().Listar();



            return Json(new { data = oLista.Where(x =>!x.Edificio) }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        } 
        
        public ActionResult DN()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        
        public ActionResult DGA()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Buscar()
        {
            ViewBag.Message = "Busque su dispositivo";

            return View();
        }
    }
}