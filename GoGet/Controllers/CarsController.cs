using GoGet.Models;
using GoGet.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace GoGet.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars

        public ActionResult Index()
        {
            var car = GetCars();
            return View(car);
        }

        private IEnumerable<Car> GetCars()
        {
            return new List<Car>
            {
                new Car { Id = 1, Name = "Nissan" },
                new Car { Id = 2, Name = "Audi" }
            };
        }
        public ActionResult Random()
        {
            var car = new Car() { Name = "Nissan!" };
            var customers = new List<Customer>
            {
                new Customer { Name="Zerub"},
                new Customer { Name= "Roberts"}
                
            };
            var viewModel = new RandomCarViewModel
            {
                Car = car,
                Customers = customers
            };
            return View(viewModel);
        }
        public ActionResult Edit(int id )
        {
            return Content("id=" + id);
        }

        [Route("cars/released/{year:regex(\\d{4})}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year +"/ " + month);
        }
    }
}