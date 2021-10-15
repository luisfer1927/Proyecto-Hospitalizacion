using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Veterinaria.App.Persistencia.AppRepositorios;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Presentacion.Pages
{
    public class Lista_VetModel: PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinarios;

        public IEnumerable<Veterinario> Veterinarios{get;set;}
        
        public Lista_VetModel()
        {
            this.repositorioVeterinarios=new RepositorioVeterinario(new Veterinaria.App.Persistencia.AppContext());
        } 
        public void OnGet()
        {
            Veterinarios=repositorioVeterinarios.GetAll();
        }
    }
}
