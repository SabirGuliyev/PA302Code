using Microsoft.AspNetCore.Mvc;

namespace FirstMVCExample.Controllers
{
    public class HomeController:Controller
    {

        public ViewResult Index()
        {


            return View();





            //JsonResult json=new JsonResult(new
            //{
            //    Name = "Salam",
            //    Surname = "Salamov"
            //});


            //return Content("Salam gencler");


        }

        public ViewResult Details(int? id)
        {
            if (id is null || id < 1)
            {
                return BadRequest();
            }

            return View("Product");


            //return id*id;
        }
    }
}
