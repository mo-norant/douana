using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Douana.Controllers;

namespace Douana.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : DouanaControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
