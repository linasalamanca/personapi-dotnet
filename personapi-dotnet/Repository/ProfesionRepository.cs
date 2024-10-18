using Microsoft.EntityFrameworkCore;
using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Repository
{
    public class ProfesionRepository : IProfesionRepository
    {
        private readonly PersonaDbContext _context;

        public ProfesionRepository(PersonaDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Profesion>> GetAllProfesionesAsync()
        {
            return await _context.Profesions.AsNoTracking().ToListAsync();
        }

        public async Task<Profesion> GetProfesionesByIdAsync(int id)
        {
            return await _context.Profesions
                .Include(p => p.Estudios)
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task AddProfesionAsync(Profesion profesion)
        {
            try
            {
                _context.Profesions.Add(profesion);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("Error al agregar la profesión", ex);
            }
        }

        public async Task UpdateProfesionAsync(Profesion profesion)
        {
            if (!await _context.Profesions.AnyAsync(p => p.Id == profesion.Id))
            {
                throw new KeyNotFoundException("La profesión no existe");
            }

            _context.Entry(profesion).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProfesionAsync(int id)
        {
            var profesion = await _context.Profesions.FindAsync(id);
            if (profesion != null)
            {
                _context.Profesions.Remove(profesion);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException("La profesión no existe");
            }
        }

        public async Task<Profesion> GetProfesionByIdAsync(int id)
        {
            return await _context.Profesions
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Id == id);
        }


    }
}