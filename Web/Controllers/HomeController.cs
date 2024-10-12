using CapaNegocio.service;
using Datos.entidades;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ObraService _obraService; 

        // Constructor con inyección de dependencia
        public HomeController(ObraService obraService)
        {
            _obraService = obraService; 
        }
        public async Task<IActionResult> Index()
        {
            var listObras = await _obraService.GetAllObrasAsync(); 
            ViewBag.Obras = listObras;

            return View();
        }

        [HttpPost] 
        public async Task<IActionResult> CrearObra(Obra obra) 
        {
            if (ModelState.IsValid) 
            {
                await _obraService.AddObraAsync(obra);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }


    }
}
