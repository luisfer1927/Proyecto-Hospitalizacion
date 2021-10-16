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
    public class Delete_M : PageModel
    {
       private readonly IRepositorioMascota repositorioMascota;
        [BindProperty]
        public Mascota Mascota {get;set;}

        public Delete_M()
        {
            this.repositorioMascota =new RepositorioMascota(new Veterinaria.App.Persistencia.AppContext());

        }  
        public IActionResult OnGet(int? MascotaId)
        {
            if (MascotaId.HasValue)
            {
                Mascota =repositorioMascota.GetMascota(MascotaId.Value);
            }
            
            if (Mascota == null)
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
            if(Mascota.id>0)
            {
             repositorioMascota.DeleteMascota(Mascota.id);
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
