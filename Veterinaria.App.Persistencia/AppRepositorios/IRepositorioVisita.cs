using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVisita
    {
        Visita AddVisita(Visita visita);
        void DeleteVisita(int idVisita);
        IEnumerable<Visita> GetAll();
        Visita GetVisita(int idVisita);
        Visita UpdateVisita(Visita visita);
        Visita UpdateVeterinario(Visita visita, int idVisita);
    }


}