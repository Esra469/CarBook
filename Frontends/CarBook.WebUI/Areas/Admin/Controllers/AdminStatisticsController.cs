using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    //bu controller içinde bulunan metotların tamamnı bu dizini alarak ilerleycek
    [Route("Admin/AdminStatistics")]
    public class AdminStatisticsController : Controller
    {
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
