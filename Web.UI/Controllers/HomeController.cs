// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeController.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the HomeController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Web.UI.Controllers
{
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            this.ViewData["SubTitle"] = "Welcome in ASP.NET MVC 5 INSPINIA SeedProject ";
            this.ViewData["Message"] = "It is an application skeleton for a typical MVC 5 project. You can use it to quickly bootstrap your webapp projects.";

            return this.View();
        }

        public ActionResult Minor()
        {
            this.ViewData["SubTitle"] = "Simple example of second view";
            this.ViewData["Message"] = "Data are passing to view by ViewData from controller";

            return this.View();
        }
    }
}