using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Persistencia.AppRepositorios
{
    public class RepositorioEstadosalud : IRepositorioEstadosalud
    {

        private readonly AppContext _appContext;

        public RepositorioEstadosalud(AppContext appContext)
        {
            _appContext = appContext;
        }

        EstadodeSalud IRepositorioEstadosalud.Addsalud(EstadodeSalud salud)
        {
             var EstadoAdicionado = _appContext.estadosalud.Add(salud);
            _appContext.SaveChanges();
            return EstadoAdicionado.Entity;
        }
         void IRepositorioEstadosalud.Deletesalud(int idEstadodeSalud)
        {
            var EstadoEncontrado = _appContext.estadosalud.FirstOrDefault(c => c.id == idEstadodeSalud);
            if (EstadoEncontrado == null)
                return;
            _appContext.estadosalud.Remove(EstadoEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<EstadodeSalud> IRepositorioEstadosalud.GetAll()
        {
           return _appContext.estadosalud;
        }
        EstadodeSalud IRepositorioEstadosalud.Getsalud(int Estadosaludid)
        {
            return _appContext.estadosalud.FirstOrDefault(c => c.id == Estadosaludid);
        }
         EstadodeSalud IRepositorioEstadosalud.Updatesalud(EstadodeSalud salud)
        {
            var estadosalud= _appContext.estadosalud.SingleOrDefault(r => r.id==salud.id);
            if(estadosalud!=null)
            {
                estadosalud.id=salud.id;
                estadosalud.temperatura=salud.temperatura;
                estadosalud.Frecu_Respi=salud.Frecu_Respi;
                estadosalud.Frecu_Cardia=salud.Frecu_Cardia;
                estadosalud.Estado_Animo=salud.Estado_Animo;
                estadosalud.recomendacion=salud.recomendacion;
                estadosalud.Peso=salud.Peso;
                estadosalud. masco_estadosalud=salud. masco_estadosalud;
                estadosalud.visit=salud.visit;

                _appContext.SaveChanges();
            }
            return estadosalud ;
        }
        public EstadodeSalud Updatesalud(EstadodeSalud salud, int idsalud)
        {
            throw new System.NotImplementedException();
        }

    }
}