using appGIUCT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace appGIUCT.Domain.Repository{
    public interface ITesinaLicenciaturaRepo
    {
           Task<Facultad> GetFacultad(int id);
    }
}