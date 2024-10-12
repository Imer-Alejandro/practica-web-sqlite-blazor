using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.entidades
{
    public class Obra
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public string Idioma { get; set; }
        public string FotoUrl { get; set; }
        public string Resumen { get; set; }

        // Relación con Personajes
        public List<Personaje> Personajes { get; set; } = new List<Personaje>();
    }
}
