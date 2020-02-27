using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace TopShelf.Controllers
{
    public class PenaltyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult PenaltyGroup()
        {
            return View();
        }


    }

}