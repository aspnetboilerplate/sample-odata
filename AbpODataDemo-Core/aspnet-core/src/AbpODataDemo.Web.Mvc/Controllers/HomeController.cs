using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using AbpODataDemo.Controllers;

namespace AbpODataDemo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AbpODataDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
