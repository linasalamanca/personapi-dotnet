using personapi_dotnet.Models.Entities;

public interface IProfesionRepository
{
    Task<Profesion> GetProfesionByIdAsync(int id);
    Task<IEnumerable<Profesion>> GetAllProfesionesAsync();
    Task AddProfesionAsync(Profesion profesion);
    Task UpdateProfesionAsync(Profesion profesion);
    Task DeleteProfesionAsync(int id);
}