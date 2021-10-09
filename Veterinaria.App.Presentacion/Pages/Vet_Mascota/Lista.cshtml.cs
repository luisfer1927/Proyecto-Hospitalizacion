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
    public class ListaModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascotas;
        
        public IEnumerable<Mascota> Mascotas{get;set;}

        public ListaModel(IRepositorioMascota repositorioMascotas)
        {
            this.repositorioMascotas=repositorioMascotas;
        } 
        
    
        public void OnGet()
        {
            Mascotas=repositorioMascotas.GetAll();
        }
    }
}
