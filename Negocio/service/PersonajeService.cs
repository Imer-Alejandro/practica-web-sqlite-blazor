using Datos.entidades;
using Datos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.service
{
    public class PersonajeService
    {
        private readonly AppDbContext _context;

        public PersonajeService(AppDbContext context)
        {
            _context = context;
        }

        // Método para obtener todos los personajes
        public async Task<List<Personaje>> GetAllPersonajesAsync()
        {
            return await _context.Personajes.ToListAsync();
        }

        // Método para obtener un personaje por su ID
        public async Task<Personaje> GetPersonajeByIdAsync(int id)
        {
            return await _context.Personajes.FirstOrDefaultAsync(p => p.Id == id);
        }

        // Método para agregar un nuevo personaje
        public async Task AddPersonajeAsync(Personaje personaje)
        {
            _context.Personajes.Add(personaje);
            await _context.SaveChangesAsync();
        }

        // Método para actualizar un personaje existente
        public async Task UpdatePersonajeAsync(Personaje personaje)
        {
            _context.Personajes.Update(personaje);
            await _context.SaveChangesAsync();
        }

        // Método para eliminar un personaje por su ID
        public async Task DeletePersonajeAsync(int id)
        {
            var personaje = await _context.Personajes.FindAsync(id);
            if (personaje != null)
            {
                _context.Personajes.Remove(personaje);
                await _context.SaveChangesAsync();
            }
        }
    }
}
