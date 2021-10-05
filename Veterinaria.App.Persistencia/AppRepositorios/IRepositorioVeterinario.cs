using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVeterinario
    {
        Veterinario AddVeterinario(Veterinario veterinario);
        void DeleteVeterinario(int idVeterinario);
        IEnumerable<Veterinario> GetAll();
        Veterinario GetVeterinario(int idVeterinario);
        Veterinario UpdateVeterinario(Veterinario veterinario);
        Veterinario UpdateVeterinario(Veterinario veterinario, int idVeterinario);
    }


}