using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace MyCompany.MyProject.Plugin.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PluginController : AbpController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
