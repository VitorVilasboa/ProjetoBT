using Microsoft.AspNetCore.Mvc;
using ProjetoBT.ViewModels;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace ProjetoBT.Controllers
{
    public class LoginController : Controller
    {
        public IConfiguration _config;

        public LoginController(IConfiguration Configuration)
        {
            _config = Configuration;
        }


        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Forms(VMLoginIndex LoginDetails)
        {
            var bValido = ValidarUsuario(LoginDetails);

            if (bValido)
            {
                return Json(new { CodigoRetorno = 1 , Mensagem = ""});
            }
            else
            {
                return Json(new { CodigoRetorno = 0, Mensagem = "Usuário não encontrado" });
            }
        }

        private bool ValidarUsuario(VMLoginIndex loginDetalhes)
        {
            if (loginDetalhes.nomeUsuario == "Vitor" && loginDetalhes.senhaUsuario == "123456")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
