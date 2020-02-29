using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
   public class HelloWorldController : Controller
   {
      /// <summary>
      /// GET: /HelloWorld/
      /// </summary>
      /// <returns></returns>
      public IActionResult Index()
      {
         return View();
      }

      /// <summary>
      /// GET: HelloWorld/Welcome/3?name=Rick Requires using System.Text.Encodings.Web;
      /// </summary>
      /// <param name="name"></param>
      /// <param name="numTimes"></param>
      /// <returns></returns>
      public IActionResult Welcome(string name, int numTimes = 1)
      {
         ViewData["Message"] = "Hello " + name;
         ViewData["NumTimes"] = numTimes;

         return View();
      }
   }
}