using AutoMapper;
using MyPortfolio.MessageApi.Context;
using MyPortfolio.MessageApi.Dtos.MessageDtos;
using MyPortfolio.MessageApi.Entities;

namespace MyPortfolio.MessageApi.Services
{
    public class MessageService : IMessageService
    {
        private readonly MyPortfolioDbContext _myPortfolioDbContext;
        private readonly IMapper _mapper;

        public MessageService(MyPortfolioDbContext myPortfolioDbContext, IMapper mapper)
        {
            _myPortfolioDbContext = myPortfolioDbContext;
            _mapper = mapper;
        }

        public async Task CreateMessageAsync(CreateMessageDto createMessageDto)
        {
            await _myPortfolioDbContext.Messages.AddAsync(_mapper.Map<Message>(createMessageDto));
            await _myPortfolioDbContext.SaveChangesAsync();
        }

        public async Task DeleteMessageAsync(int id)
        {
            var value = await GetByIdMessageAsync(id);
            _myPortfolioDbContext.Messages.Remove(_mapper.Map<Message>(value));
            await _myPortfolioDbContext.SaveChangesAsync();
        }

        public async Task<List<ResultMessageDto>> GetAllMessageAsync()
        {
            return _mapper.Map<List<ResultMessageDto>>(_myPortfolioDbContext.Messages.ToList());
        }

        public async Task<GetByIdMessageDto> GetByIdMessageAsync(int id)
        {
            return _mapper.Map<GetByIdMessageDto>(_myPortfolioDbContext.Messages.Find(id));
        }

        public async Task UpdateMessageAsync(UpdateMessageDto updateMessageDto)
        {
            _myPortfolioDbContext.Update(updateMessageDto);
            await _myPortfolioDbContext.SaveChangesAsync();
        }
    }
}
