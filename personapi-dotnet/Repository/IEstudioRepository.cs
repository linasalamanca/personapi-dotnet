﻿using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Repository
{
    public interface IEstudioRepository
    {
        Task<Estudio> GetEstudioByIdAsync(int idProf);
        Task<IEnumerable<Estudio>> GetAllEstudiosAsync();
        Task AddEstudioAsync(Estudio estudio);
        Task UpdateEstudioAsync(Estudio estudio);
        Task DeleteEstudioAsync(int idProf);
    }
}
