namespace Exam_Project.Areas.Admin.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
