using MyPortfolio.MessageApi.Dtos.ContactDtos;

namespace MyPortfolio.ContactApi.Services.ContactServices
{
    public interface IContactService
    {
        Task CreateContactAsync(CreateContactDto createContactDto);
        Task UpdateContactAsync(UpdateContactDto updateContactDto);
        Task DeleteContactAsync(int id);
        Task<List<ResultContactDto>> GetAllContactAsync();
        Task<GetByIdContactDto> GetByIdContactAsync(int id);
    }
}
