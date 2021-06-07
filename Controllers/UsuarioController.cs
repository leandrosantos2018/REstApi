using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REstApi.filters;
using REstApi.Models;
using REstApi.Models.Usuario;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REstApi.Controllers
{
    [Route("api/v1/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {   
        ///<sumary>
        ///teste
        ///</sumary>
        ///<param name="loginViewModelInput"></param>
        ///<returns>Retorna status ok, dados do usuario e o token em caso</returns>
        [SwaggerResponse(statusCode: 200,description: "Sucesso ao autenticar",Type = typeof(LoginViewModelInput))]    
        [SwaggerResponse(statusCode: 400,description: "Campo obrigatório", Type = typeof(ValidaCampoViewModelOutput))]    
        [SwaggerResponse(statusCode:500, description: "Erro interno", Type = typeof(ErroGenericoViewModel))]    
        
        [HttpPost]
        [Route("logar")]
        [ValidacaoModelstateCustomizado]
        public IActionResult Logar(LoginViewModelInput loginViewModelInput)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(new ValidaCampoViewModelOutput(ModelState.SelectMany(sm => sm.Value.Errors).Select(s => s.ErrorMessage)));
            //}

            return Ok(loginViewModelInput);
        }

        [HttpPost]
        [Route("registrar")]
        [ValidacaoModelstateCustomizado]
        public IActionResult Registrar(RegistroViewModelInput registroViewModelInput)
        {
            return Created("", registroViewModelInput);
            
        }
    }
}
