using Microsoft.AspNetCore.Mvc;

namespace WorldDominion
{
    public class DepartmentsController : Controller 
    {
        public IActionResult Index()
        {
            List<Dictionary<string, object>> data = new()
            {
                new Dictionary<string, object>{ {"Id", "1"}, {"Name", "Fruits and Veg"}},
                new Dictionary<string, object>{ {"Id", "2"}, {"Name", "Meats"}},
                new Dictionary<string, object>{ {"Id", "3"}, {"Name", "Sweets & Treats"}},
            };

            return View(data);
        }
    }
}