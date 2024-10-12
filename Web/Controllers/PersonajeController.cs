using CapaNegocio.service;
using Datos.entidades;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class PersonajeController : Controller
    {
        private readonly PersonajeService _personajeService;

        private readonly ObraService _obraService;

        public PersonajeController(PersonajeService personajeService, ObraService obraService)
        {
            _personajeService = personajeService;
            _obraService = obraService;
        }
        public async Task<IActionResult> Personaje()
        {
            var listPersonaje = await _personajeService.GetAllPersonajesAsync();
            var listObras = await _obraService.GetAllObrasAsync();

            ViewBag.Obras= listObras;
            ViewBag.Personajes = listPersonaje;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CrearPersonaje(Personaje personaje)
        {
            if (ModelState.IsValid)
            {
                await _personajeService.AddPersonajeAsync(personaje);

                return RedirectToAction("Personaje");
            }

            return RedirectToAction("Personaje");
        }
    }
}
