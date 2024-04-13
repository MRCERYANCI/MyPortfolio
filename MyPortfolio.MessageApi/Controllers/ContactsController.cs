using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.ContactApi.Services.ContactServices;
using MyPortfolio.MessageApi.Dtos.ContactDtos;

namespace MyPortfolio.ContactApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _ContactService;

        public ContactsController(IContactService ContactService)
        {
            _ContactService = ContactService;
        }

        [HttpGet]
        public async Task<IActionResult> ContactList()
        {
            var values = await _ContactService.GetAllContactAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdContact(int id)
        {
            var values = await _ContactService.GetByIdContactAsync(id);
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateContactDto(CreateContactDto createContactDto)
        {
            await _ContactService.CreateContactAsync(createContactDto);
            return Ok("İletişim Bilgileri Başarıyla Eklenmiştir");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateContactDto(UpdateContactDto updateContactDto)
        {
            await _ContactService.UpdateContactAsync(updateContactDto);
            return Ok("İletişim Bilgileri Başarıyla Güncellenmiştir");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteContact(int id)
        {
            await _ContactService.DeleteContactAsync(id);
            return Ok("İletişim Bilgileri Başarıya Silinmiştir");
        }
    }
}
