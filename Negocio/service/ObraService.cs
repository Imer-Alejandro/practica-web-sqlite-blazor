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
    public class ObraService
    {
        private readonly AppDbContext _context;

        public ObraService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Obra>> GetAllObrasAsync()
        {
            return await _context.Obras.Include(o => o.Personajes).ToListAsync();
        }

        public async Task<Obra> GetObraByIdAsync(int id)
        {
            return await _context.Obras.Include(o => o.Personajes).FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task AddObraAsync(Obra obra)
        {
            _context.Obras.Add(obra);
            await _context.SaveChangesAsync();
        }
    }
}
