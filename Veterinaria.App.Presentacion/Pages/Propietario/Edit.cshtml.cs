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
    public class EditModel : PageModel
    {
       private readonly IRepositorioPropietario RepositorioPropietario;

        public Propietario Propietario {get;set;}

        public EditModel(IRepositorioPropietario repositorioPropietario)
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
        /*
        public IActionResult OnGet(int? PropietarioId)
        {
            if (PropietarioId.HasValue)
            {
                Propietario = repositorioPropietario.GetSaludoPorId(PropietarioId.Value);
            }
            else
            {
                Propietario = new Propietario();
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
            Propietario = repositorioPropietario.Update(Propietario);
            }
            else
            {
             repositorioPropietario.Add(Propietario);
            }
            return Page();
        }
        */
    }
}
