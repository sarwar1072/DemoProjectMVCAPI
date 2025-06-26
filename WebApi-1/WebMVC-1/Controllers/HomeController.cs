using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebMVC_1.Models;

namespace WebMVC_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HttpClient _httpClient;    
        public HomeController(ILogger<HomeController> logger, HttpClient httpClient)
        {
            _logger = logger;
            _httpClient = httpClient;   
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model=new OrderDTO();
            return View(model);
        }
        //public async Task<IActionResult> Create()
        //{
        //    var model = new OrderDTO();
        //    return View(model);
        //}
        [HttpPost]  
        public async Task<IActionResult> Create(OrderDTO order)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Order/Create", order);

              if (response.IsSuccessStatusCode)
                {
                    TempData["Msg"] = "Order saved successfully.";
                }
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
