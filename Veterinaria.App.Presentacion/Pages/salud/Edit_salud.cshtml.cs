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
    public class Edit_saludModel : PageModel
    {
        private readonly IRepositorioEstadosalud repositorioEstadosalud;
        [BindProperty]
        public EstadodeSalud estadodeSalud {get;set;}

        public IEnumerable<EstadodeSalud> listasalud{get;set;}

        public Edit_saludModel()
        {
            this.repositorioEstadosalud =new RepositorioEstadosalud(new Veterinaria.App.Persistencia.AppContext());

        }  
        public IActionResult OnGet(int? EstadodeSaludId)
        {
            if (EstadodeSaludId.HasValue)
            {
                estadodeSalud = repositorioEstadosalud.Getsalud(EstadodeSaludId.Value);
            }
            else
            {
                estadodeSalud = new EstadodeSalud();
            }
            if (estadodeSalud == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(estadodeSalud.id>0)
            {
            estadodeSalud = repositorioEstadosalud.Updatesalud(estadodeSalud);
            }
            else
            {
             repositorioEstadosalud.Addsalud(estadodeSalud);
            }
            return Page();
        }
    }
}
