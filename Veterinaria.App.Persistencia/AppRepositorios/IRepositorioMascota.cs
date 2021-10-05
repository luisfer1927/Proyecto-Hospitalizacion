using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMascota
    {
        Mascota AddMascota(Mascota mascota);
        void DeleteMascota(int idMascota);
        IEnumerable<Mascota> GetAll();
        Mascota GetMascota(int idMascota);
        Mascota UpdateMascota(Mascota mascota);
        Mascota UpdateMascota(Mascota mascota, int idMascota);
    }


}