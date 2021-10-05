using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Persistencia.AppRepositorios
{
    public interface IRepositorioEstadosalud
    {
        EstadodeSalud Addsalud(EstadodeSalud salud);
        void Deletesalud(int idEstadodeSalud);
        IEnumerable<EstadodeSalud> GetAll();
        EstadodeSalud Getsalud(int idsalud);
        EstadodeSalud Updatesalud(EstadodeSalud salud);
        EstadodeSalud Updatesalud(EstadodeSalud salud, int idsalud);
    }


}