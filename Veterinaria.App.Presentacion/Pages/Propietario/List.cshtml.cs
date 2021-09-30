using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia.AppRepositorios;

namespace Veterinaria.App.Presentacion.Pages
{
    public class ListModel : PageModel
    {
        private readonly IRepositorioPropietario repositorioPropietario;
        public IEnumerable<Propietario> Propietario{get;set;}
        public ListModel(IRepositorioPropietario repositorioPropietario)
        {
            this.repositorioPropietario=repositorioPropietario;
        } 
        public void OnGet()
        {
            Propietario=repositorioPropietario.GetAll();
        }
    }
}
