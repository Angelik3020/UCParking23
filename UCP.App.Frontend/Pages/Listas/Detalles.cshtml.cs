using System.Net.Sockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UCP.App.Dominio;
using UCP.App.Persistencia;

namespace UCP.App.Frontend.Pages
{
    public class DetallesModel : PageModel
    {
        public static IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new Persistencia.AppContext());
        
        public Profesor Profesor {get;set;}

        public IActionResult OnGet(int profesorId)
        {
            Profesor =_repoProfesor.GetProfesor(profesorId);
            //Console.WriteLine(profesor.vehiculo_1);//pendiente
            if(Profesor==null)
            {
                return RedirectToPage("./Personas");
            }else
            return Page();        
        }
    }
}
