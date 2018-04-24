using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdminProj.Pages.Administrador.Usuarios
{
    public class CadastroModel : PageModel
    {
        public CadastroModel()
        {

        }


        public class InputModel
        {
            [Required] 
            public string Username { get; set; }

            [Required] 
            public string Nome { get; set; }

            [Required] 
            public string Sobrenome { get; set; }

            [Required] 
            public string Sexo { get; set; }

            [Required]
            [EmailAddress]
            public string Email { get; set; }

        }


        public void OnGet()
        {

        }
    }
}