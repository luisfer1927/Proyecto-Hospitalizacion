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
    public class Details_MasModel : PageModel
    {
        private readonly IRepositorioMascota RepositorioMascota;

        public Mascota Mascota {get;set;}

        public Details_MasModel(IRepositorioMascota repositorioMascota)
        {
            this.RepositorioMascota = repositorioMascota;

        }

        public IActionResult OnGet(int Mascotaid)
        {
            Mascota = RepositorioMascota.GetMascota(Mascotaid);
            if (Mascota==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }
    }
}
