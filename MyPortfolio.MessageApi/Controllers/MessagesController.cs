using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.MessageApi.Dtos.MessageDtos;
using MyPortfolio.MessageApi.Services.MessageServices;

namespace MyPortfolio.MessageApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessagesController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet]
        public async Task<IActionResult> MessageList()
        {
            var values = await _messageService.GetAllMessageAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdMessage(int id)
        {
            var values = await _messageService.GetByIdMessageAsync(id);
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateMessageDto(CreateMessageDto createMessageDto)
        {
            await _messageService.CreateMessageAsync(createMessageDto);
            return Ok("Mesaj Başarıyla Eklenmiştir");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateMessageDto(UpdateMessageDto updateMessageDto)
        {
            await _messageService.UpdateMessageAsync(updateMessageDto);
            return Ok("Mesaj Başarıyla Güncellenmiştir");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteMessage(int id)
        {
            await _messageService.DeleteMessageAsync(id);
            return Ok("Mesaj Başarıya Silinmiştir");
        }
    }
}
