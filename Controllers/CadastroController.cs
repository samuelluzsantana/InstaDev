using Microsoft.AspNetCore.Mvc;

namespace InstaDev.Controllers
{
    public class CadastroController : Controller
    {
        [Route("Cadastro")]
        public IActionResult Index(){
            return View();
        }

    }
}