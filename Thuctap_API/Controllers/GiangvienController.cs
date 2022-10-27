using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Thuctap_API.Controllers
{
    public class GiangvienController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
