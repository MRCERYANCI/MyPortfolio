using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Dtos.MessageDtos;
using Newtonsoft.Json;
using System.Text;

namespace MyPortfolio.Controllers
{
    public class MessageController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MessageController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<JsonResult> CreateMessageJson(CreateMessageDto createMessageDto)
        {
            if (createMessageDto != null)
            {
                var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(createMessageDto);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");//İçeriğin dönüşümü için kullancaz(content,encoding,mediaType)
                var responseMessage = await client.PostAsync("https://localhost:7189/api/Messages", stringContent);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return Json("1");
                }
            }

            return Json("0");
        }
    }
}
