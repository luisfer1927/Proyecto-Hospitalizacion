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
    public class Editar_VetModel : PageModel
    {
        private readonly IRepositorioVeterinario RepositorioVeterinario;
        [BindProperty]
        public Veterinario Veterinario {get;set;}

        public Editar_VetModel() 
        {
            this.RepositorioVeterinario = new RepositorioVeterinario(new Veterinaria.App.Persistencia.AppContext());
               
        }

        public IActionResult OnGet(int? VeterinarioId)
        {
            if (VeterinarioId.HasValue)
            {
                Veterinario = RepositorioVeterinario.GetVeterinario(VeterinarioId.Value);
            }
            else
            {
                Veterinario = new Veterinario();
            }
            if (Veterinario == null)
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
            if(Veterinario.Id>0)
            {
            Veterinario= RepositorioVeterinario.UpdateVeterinario(Veterinario);
            }
            else
            {
             RepositorioVeterinario.AddVeterinario(Veterinario);
            }
            return Page();
        }
    }
}
               

