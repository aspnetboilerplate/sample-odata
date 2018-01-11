using Microsoft.AspNetCore.Antiforgery;
using AbpODataDemo.Controllers;

namespace AbpODataDemo.Web.Host.Controllers
{
    public class AntiForgeryController : AbpODataDemoControllerBase
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
