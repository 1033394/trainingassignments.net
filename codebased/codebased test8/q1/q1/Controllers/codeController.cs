using System.Web.Mvc;

namespace q1.Controllers
{
    public class codeController : Controller
    {
        private readonly Northwind_context; 

        public codeController(Northwind context)
        {
            Northwind_context = context;
        }

        public IActionResult AllCustomersInGermany()
        {
            var germanCustomers = _context.Customers.Where(c => c.Country == "Germany").ToList();
            return View(germanCustomers);
        }



    }
}