using AutoMapper;
using MyPortfolio.MessageApi.Dtos.ContactDtos;
using MyPortfolio.MessageApi.Context;
using MyPortfolio.MessageApi.Entities;

namespace MyPortfolio.ContactApi.Services.ContactServices
{
    public class ContactService : IContactService
    {
        private readonly MyPortfolioDbContext _myPortfolioDbContext;
        private readonly IMapper _mapper;

        public ContactService(MyPortfolioDbContext myPortfolioDbContext, IMapper mapper)
        {
            _myPortfolioDbContext = myPortfolioDbContext;
            _mapper = mapper;
        }

        public async Task CreateContactAsync(CreateContactDto createContactDto)
        {
            await _myPortfolioDbContext.Contacts.AddAsync(_mapper.Map<Contact>(createContactDto));
            await _myPortfolioDbContext.SaveChangesAsync();
        }

        public async Task DeleteContactAsync(int id)
        {
            var value = await GetByIdContactAsync(id);
            _myPortfolioDbContext.Contacts.Remove(_mapper.Map<Contact>(value));
            await _myPortfolioDbContext.SaveChangesAsync();
        }

        public async Task<List<ResultContactDto>> GetAllContactAsync()
        {
            return _mapper.Map<List<ResultContactDto>>(_myPortfolioDbContext.Contacts.ToList());
        }

        public async Task<GetByIdContactDto> GetByIdContactAsync(int id)
        {
            return _mapper.Map<GetByIdContactDto>(_myPortfolioDbContext.Contacts.Find(id));
        }

        public async Task UpdateContactAsync(UpdateContactDto updateContactDto)
        {
            _myPortfolioDbContext.Update(updateContactDto);
            await _myPortfolioDbContext.SaveChangesAsync();
        }
    }
}
