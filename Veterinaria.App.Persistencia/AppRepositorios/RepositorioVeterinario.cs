using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Persistencia.AppRepositorios
{
    public class RepositorioVeterinario:IRepositorioVeterinario
    {
        private readonly AppContext _appContext;

        public RepositorioVeterinario(AppContext appContext)
        {
             _appContext = appContext;
        }
        Veterinario IRepositorioVeterinario.AddVeterinario(Veterinario veterinarios)
        {
           var veterinarioAdicionado = _appContext.veterinario.Add(veterinarios);
            _appContext.SaveChanges();
            return veterinarioAdicionado.Entity;
        }
        void IRepositorioVeterinario.DeleteVeterinario(int idVeterinario)
        {
            var VeterinarioEncontrado = _appContext.veterinario.FirstOrDefault(c => c.Id == idVeterinario);
            if (VeterinarioEncontrado == null)
                return;
            _appContext.veterinario.Remove(VeterinarioEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Veterinario> IRepositorioVeterinario.GetAll()
        {
            return _appContext.veterinario;
        }
        Veterinario IRepositorioVeterinario.GetVeterinario(int idVeterinario)
        {
            return _appContext.veterinario.FirstOrDefault(c => c.Id == idVeterinario);
        }
        Veterinario IRepositorioVeterinario.UpdateVeterinario(Veterinario veterinarios)
        {
            var Veterinarios= _appContext.veterinario.SingleOrDefault(r => r.Id==veterinarios.Id);
            if(Veterinarios!=null)
            {
                Veterinarios.Id=veterinarios.Id;
                Veterinarios.Nombre=veterinarios.Nombre;
                Veterinarios.Apellidos=veterinarios.Apellidos;
                Veterinarios.Telefono=veterinarios.Telefono;
                Veterinarios.Tarjeta_Profesional=veterinarios.Tarjeta_Profesional;
                _appContext.SaveChanges();
            }
            return Veterinarios;
        }
        public Veterinario UpdateVeterinario(Veterinario veterinario, int idVeterinario)
        {
            throw new System.NotImplementedException();
        }
    }

}