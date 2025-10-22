// InvoiceApps.MvcClient/Controllers/HomeController.cs
using Microsoft.AspNetCore.Mvc;

namespace InvoiceApps.MvcClient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
