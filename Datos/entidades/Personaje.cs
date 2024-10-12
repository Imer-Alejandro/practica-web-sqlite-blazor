using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.entidades
{
    public class Personaje
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apodo { get; set; }
        public string Raza { get; set; }
        public string FotoUrl { get; set; }
        public int Edad { get; set; }
        public string PoderCaracteristico { get; set; }

        // Foreign Key
        public int ObraId { get; set; }
        public Obra Obra { get; set; }
    }
}
