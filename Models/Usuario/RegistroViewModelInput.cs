using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace REstApi.Models.Usuario
{
    public class RegistroViewModelInput : ControllerBase
    {
        [Required(ErrorMessage = "O Login é obrigatório")]

        public String Login { get; set; }

        [Required(ErrorMessage = "O E-mail  é obrigatório")]

        public String Email { get; set; }

        [Required(ErrorMessage = "O Senha  é obrigatório")]

        public String Senha { get; set; }
    }
}
