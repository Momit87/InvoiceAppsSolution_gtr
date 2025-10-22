// InvoiceApps.MvcClient/Controllers/EmployeeMvcController.cs
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace InvoiceApps.MvcClient.Controllers
{
    public class EmployeeMvcController : Controller
    {
        private readonly IHttpClientFactory _httpFactory;
        private readonly IConfiguration _config;

        public EmployeeMvcController(IHttpClientFactory httpFactory, IConfiguration config)
        {
            _httpFactory = httpFactory;
            _config = config;
        }

        // The MVC views will call Web API endpoints via AJAX. This controller mainly serves the views.
        public IActionResult Index() => View();

        public IActionResult Edit(int id) => View(model: id);
    }
}
