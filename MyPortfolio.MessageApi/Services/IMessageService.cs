using MyPortfolio.MessageApi.Dtos.MessageDtos;

namespace MyPortfolio.MessageApi.Services
{
    public interface IMessageService
    {
        Task CreateMessageAsync(CreateMessageDto createMessageDto);
        Task UpdateMessageAsync(UpdateMessageDto updateMessageDto);
        Task DeleteMessageAsync(int id);
        Task<List<ResultMessageDto>> GetAllMessageAsync();
        Task<GetByIdMessageDto> GetByIdMessageAsync(int id);
    }
}
