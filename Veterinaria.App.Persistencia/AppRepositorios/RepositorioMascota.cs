using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Persistencia.AppRepositorios
{
    public class RepositorioMascota : IRepositorioMascota
    {
        public RepositorioMascota()
        {

        }
        public Mascota AddMascota(Mascota mascota)
        {
            throw new System.NotImplementedException();
        }
        public void DeleteMascota(int idMascota)
        {
            throw new System.NotImplementedException();
        }
        public IEnumerable<Mascota> GetAll()
        {
            throw new System.NotImplementedException();
        }
        public Mascota GetMascota(int idMascota)
        {
            throw new System.NotImplementedException();
        }
        public Mascota UpdateMascota(Mascota mascota)
        {
            throw new System.NotImplementedException();
        }
        public Mascota UpdateMascota(Mascota mascota, int idMascota)
        {
            throw new System.NotImplementedException();
        }
    }
}