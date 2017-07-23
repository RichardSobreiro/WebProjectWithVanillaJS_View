using System.Web.Mvc;

namespace VidaEsportivaView.Controllers
{
    public class AutenticacaoController : Controller
    {
        public ActionResult Login()
        {
            return new FilePathResult("~/Views/Autenticacao/Login.html", "text/html");
        }
    }
}