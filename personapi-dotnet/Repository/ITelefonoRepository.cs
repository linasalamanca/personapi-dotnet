using personapi_dotnet.Models.Entities;

public interface ITelefonoRepository
{
    Task<Telefono> GetTelefonoByIdAsync(string num);
    Task<IEnumerable<Telefono>> GetAllTelefonosAsync();
    Task AddTelefonoAsync(Telefono telefono);
    Task UpdateTelefonoAsync(Telefono telefono);
    Task DeleteTelefonoAsync(string num);
}