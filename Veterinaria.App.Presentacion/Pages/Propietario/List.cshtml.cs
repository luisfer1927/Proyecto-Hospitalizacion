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
        private readonly IRepositorioPropietario repositorioPropietarios;
        public IEnumerable<Propietario> Propietarios{get;set;}
        public ListModel(IRepositorioPropietario repositorioPropietarios)
        {
            this.repositorioPropietarios=repositorioPropietarios;
        } 
        public void OnGet()
        {
            Propietarios=repositorioPropietarios.GetAll();
        }
    }
}
