using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Dtos.ContactDtos;
using Newtonsoft.Json;
namespace MyPortfolio.ViewComponents.DefaultViewComponents
{
    public class _ContactDefaultLayoutComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ContactDefaultLayoutComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7189/api/Contacts/1");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();//Bu veri json türü
                var values = JsonConvert.DeserializeObject<GetByIdContactDto>(jsondata);
                return View(values);
            }
            return View();
        }
    }
}
