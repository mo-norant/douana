using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Douana.Controllers;

namespace Douana.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : DouanaControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
