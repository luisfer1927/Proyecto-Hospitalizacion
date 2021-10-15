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
    public class Detalles_VetModel : PageModel
    {
        private readonly IRepositorioVeterinario RepositorioVeterinario;

        public Veterinario Veterinario {get;set;}

        public Detalles_VetModel() 
        {
            this.RepositorioVeterinario = new RepositorioVeterinario(new Veterinaria.App.Persistencia.AppContext());    
        }

        public IActionResult OnGet(int VeterinarioId)
        {
            Veterinario = RepositorioVeterinario.GetVeterinario(VeterinarioId);
            if (Veterinario==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
    }
}

