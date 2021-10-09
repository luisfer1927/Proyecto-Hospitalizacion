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
        
        public Mascota AddMascota(Mascota mascotas)
        {
            mascotas.id=mascota.Max(r => r.id)+1;
           mascota.Add(mascotas);
           return mascotas;
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
        public Mascota UpdateMascota(Mascota mascotaactualizado)
        {
             var Mascotas= mascota.SingleOrDefault(r => r.id==mascotaactualizado.id);
            if(Mascotas!=null)
            {
                Mascotas.id=mascotaactualizado.id;
                Mascotas.Nombre=mascotaactualizado.Nombre;
                Mascotas.Edad=mascotaactualizado.Edad;
                Mascotas.Tipo_Mascota=mascotaactualizado.Tipo_Mascota;
                Mascotas.Estado_Salud=mascotaactualizado.Estado_Salud;
                Mascotas.dueño=mascotaactualizado.dueño;
                
            }
            return Mascotas;
        }
        public Mascota UpdateMascota(Mascota mascota, int idMascota)
        {
            throw new System.NotImplementedException();
        }
    }
}