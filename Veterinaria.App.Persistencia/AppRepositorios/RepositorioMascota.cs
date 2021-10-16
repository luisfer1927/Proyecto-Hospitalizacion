using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Persistencia.AppRepositorios
{
    public class RepositorioMascota : IRepositorioMascota
    {
       private readonly AppContext _appContext;
        
        public RepositorioMascota(AppContext appContext)
        {
            _appContext = appContext;
        }
        
       Mascota IRepositorioMascota.AddMascota(Mascota mascotas)
        {
           var mascotaAdicionado = _appContext.mascota.Add(mascotas);
            _appContext.SaveChanges();
            return mascotaAdicionado.Entity;
        }
        void IRepositorioMascota.DeleteMascota(int idMascota)
        {
            var MascotaEncontrado = _appContext.mascota.FirstOrDefault(c => c.id == idMascota);
            if (MascotaEncontrado == null)
                return;
            _appContext.mascota.Remove(MascotaEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Mascota> IRepositorioMascota.GetAll()
        {
            return _appContext.mascota;
        }
        Mascota IRepositorioMascota.GetMascota(int idMascota)
        {
            return _appContext.mascota.FirstOrDefault(c => c.id == idMascota);
        }
        Mascota IRepositorioMascota.UpdateMascota(Mascota mascotaactualizado)
        {
             var Mascotas= _appContext.mascota.SingleOrDefault(r => r.id==mascotaactualizado.id);
            if(Mascotas!=null)
            {
                Mascotas.id=mascotaactualizado.id;
                Mascotas.Nombre=mascotaactualizado.Nombre;
                Mascotas.Edad=mascotaactualizado.Edad;
                Mascotas.Tipo_Mascota=mascotaactualizado.Tipo_Mascota;
                Mascotas.Estado_Salud=mascotaactualizado.Estado_Salud;
                Mascotas.dueño=mascotaactualizado.dueño;
                Mascotas.Nombre_dueño=mascotaactualizado.Nombre_dueño;
                
                _appContext.SaveChanges();
            }
            return Mascotas;
        }
        public Mascota UpdateMascota(Mascota mascota, int idMascota)
        {
            throw new System.NotImplementedException();
        }
    }
}