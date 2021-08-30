using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistemaborrador.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage ="El campo Usuario es requerido")]
        public string Usuario { get; set; }
        [BindProperty]
        [Display(Name="Contraseña")]
        [Required(ErrorMessage ="El campo Password es requerido")]
        public string Password { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
    
        }


        public ActionResult OnPost()
        {
           if (!ModelState.IsValid)
            {
                return Page();
            }
            
            var usuario = this.Usuario;
            var pass = this.Password;

            return Page();
        }
    }
}
