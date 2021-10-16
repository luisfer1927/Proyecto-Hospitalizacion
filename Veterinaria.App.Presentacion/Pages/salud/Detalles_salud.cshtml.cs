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
    public class Detalles_saludModel : PageModel
    {
        private readonly IRepositorioEstadosalud repositorioEstadosalud;

        public EstadodeSalud estadodeSalud {get;set;}

        public Detalles_saludModel()
        {
            this.repositorioEstadosalud = new RepositorioEstadosalud(new Veterinaria.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int EstadodeSaludId)
        {
            estadodeSalud = repositorioEstadosalud.Getsalud(EstadodeSaludId);
            if (estadodeSalud==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }
    }
}
