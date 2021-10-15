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
    public class DeleteModel : PageModel
    {
       private readonly IRepositorioPropietario RepositorioPropietario;
        [BindProperty]
        public Propietario Propietario {get;set;}

        public DeleteModel()
        {
            this.RepositorioPropietario =new RepositorioPropietario(new Veterinaria.App.Persistencia.AppContext());

        }  
        public IActionResult OnGet(int? PropietarioId)
        {
            if (PropietarioId.HasValue)
            {
                Propietario = RepositorioPropietario.GetPropietario(PropietarioId.Value);
            }
            
            if (Propietario == null)
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
            if(Propietario.Id>0)
            {
             RepositorioPropietario.DeletePropietario(Propietario.Id);
            }
            
            return Page();
        }

    }
    
    /*public class DeleteModel : PageModel
    {
        public void OnGet()
        {
        }
    }*/

}
