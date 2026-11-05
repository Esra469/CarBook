using CarBook.Dto.ContactDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateContactDtos createContactDtos)
        {
            var client=_httpClientFactory.CreateClient();
            createContactDtos.SendDate = DateTime.Now;
            //metin alıp json a döndürme
            var jsonData = JsonConvert.SerializeObject(createContactDtos);
            StringContent stringContent= new StringContent(jsonData,Encoding.UTF8,"application/json");

            var responseMessage = await client.PostAsync("http://localhost:5011/api/Contacts",stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Default");

            }
            return View();

        }
    }
}
