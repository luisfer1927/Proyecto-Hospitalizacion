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
    public class Delete_saludModel : PageModel
    {
private readonly IRepositorioEstadosalud repositorioEstadosalud;
        [BindProperty]
     
         public EstadodeSalud estadodeSalud {get;set;}

        public Delete_saludModel()
        {
            this.repositorioEstadosalud =new RepositorioEstadosalud(new Veterinaria.App.Persistencia.AppContext());

        }  
        public IActionResult OnGet(int? EstadodeSaludId)
        {
            if (EstadodeSaludId.HasValue)
            {
                estadodeSalud = repositorioEstadosalud.Getsalud(EstadodeSaludId.Value);
            }
            
            if (estadodeSalud  == null)
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
            if(estadodeSalud .id>0)
            {
             repositorioEstadosalud.Deletesalud(estadodeSalud.id);
            }
            
            return Page();
        }
    }
}
