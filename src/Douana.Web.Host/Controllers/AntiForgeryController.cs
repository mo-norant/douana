using Microsoft.AspNetCore.Antiforgery;
using Douana.Controllers;

namespace Douana.Web.Host.Controllers
{
    public class AntiForgeryController : DouanaControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
