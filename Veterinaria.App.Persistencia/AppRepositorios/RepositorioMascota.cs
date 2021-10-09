using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Persistencia.AppRepositorios
{
    public class RepositorioMascota : IRepositorioMascota
    {
        List<Mascota> mascota;

        public RepositorioMascota()
        {
            mascota = new List<Mascota>()
            {
                new Mascota{id=6,Nombre="Firulais",Edad="4",Tipo_Mascota="Perro",Estado_Salud="Enfermo",dueño="Mateo"},
                new Mascota{id=7,Nombre="Troski",Edad="2",Tipo_Mascota="Perro",Estado_Salud="Sano",dueño="Luis"},
                new Mascota{id=8,Nombre="mififi",Edad="2",Tipo_Mascota="Gato",Estado_Salud="Sano",dueño="Oscar"},
                new Mascota{id=9,Nombre="Karuso",Edad="5",Tipo_Mascota="Perro",Estado_Salud="Sano",dueño="Javier"},
                new Mascota{id=10,Nombre="Krin",Edad="3",Tipo_Mascota="Perro",Estado_Salud="Sano",dueño="Jorge"}

            };
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
            return mascota;
        }
        public Mascota GetMascota(int idMascota)
        {
            return mascota.SingleOrDefault(s => s.id==idMascota);
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