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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioPropietario RepositorioPropietario;

        public Propietario Propietario {get;set;}

        public DetailsModel(IRepositorioPropietario repositorioPropietario)
        {
            this.RepositorioPropietario = repositorioPropietario;

        }

        public IActionResult OnGet(int PropietarioId)
        {
            Propietario = RepositorioPropietario.GetPropietario(PropietarioId);
            if (Propietario==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
    }
}
