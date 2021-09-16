using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutionSoftware_API_Bhupinder.Controllers
{
    public class SubjectAPIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
