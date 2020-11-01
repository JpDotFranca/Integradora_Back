using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Authentication;

namespace Trabalho_Integradora.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AutenticacaoController : ControllerBase
    {

        public ActionResult<string> Autenticar(string login, string senha)
        {

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(senha))
                throw new AuthenticationException("O login ou a senha estão incorretos ou não foram informados. Por favor, verifique os dados e tente novamente.");

            return Guid.NewGuid().ToString();
        }

    }
}