using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Persistencia.AppRepositorios
{
    public class RepositorioPropietario : IRepositorioPropietario
    {
       private readonly AppContext _appContext;
       
        public RepositorioPropietario(AppContext appContext)
        {
            _appContext = appContext;
        }
        Propietario IRepositorioPropietario.AddPropietario(Propietario propietarios)
        {
           var propietarioAdicionado = _appContext.propietario.Add(propietarios);
            _appContext.SaveChanges();
            return propietarioAdicionado.Entity;
        }

        void IRepositorioPropietario.DeletePropietario(int idPropietario)
        {
            var PropietarioEncontrado = _appContext.propietario.FirstOrDefault(c => c.Id == idPropietario);
            if (PropietarioEncontrado == null)
                return;
            _appContext.propietario.Remove(PropietarioEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Propietario> IRepositorioPropietario.GetAll()
        {
            return _appContext.propietario;
        }

        Propietario IRepositorioPropietario.GetPropietario(int IdPropietario)
        {
            return _appContext.propietario.FirstOrDefault(c => c.Id == IdPropietario);
        }

        Propietario IRepositorioPropietario.UpdatePropietario(Propietario propietarioactualizado)
        {
            var Propietarios= _appContext.propietario.SingleOrDefault(r => r.Id==propietarioactualizado.Id);
            if(Propietarios!=null)
            {
                Propietarios.Id=propietarioactualizado.Id;
                Propietarios.Nombre=propietarioactualizado.Nombre;
                Propietarios.Apellidos=propietarioactualizado.Apellidos;
                Propietarios.Cedula=propietarioactualizado.Cedula;
                Propietarios.Correo=propietarioactualizado.Correo;
                Propietarios.Direccion=propietarioactualizado.Direccion;
                Propietarios.Telefono=propietarioactualizado.Telefono;

                _appContext.SaveChanges();
            }
            return Propietarios;
        }

        public Propietario UpdatePropietario(Propietario propietario, int idPropietario)
        {
            throw new System.NotImplementedException();
        }
    }
}