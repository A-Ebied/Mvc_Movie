using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        /*
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }
        */
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        /*----------------------------
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;             //Funcation Welcome

        //  HelloWorld/Welcome?name=Rick&NumTimes=5
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

        ----------------------------------------------------------*/


        /*-----------------------------------
        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
       ------------------------------------------------------------------ */

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
