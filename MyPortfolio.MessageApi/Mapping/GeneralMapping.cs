using AutoMapper;
using MyPortfolio.MessageApi.Dtos.ContactDtos;
using MyPortfolio.MessageApi.Dtos.MessageDtos;
using MyPortfolio.MessageApi.Entities;

namespace MyPortfolio.MessageApi.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<ResultMessageDto, Message>().ReverseMap();
            CreateMap<CreateMessageDto, Message>().ReverseMap();
            CreateMap<UpdateMessageDto, Message>().ReverseMap();
            CreateMap<GetByIdMessageDto, Message>().ReverseMap();

            CreateMap<ResultContactDto, Contact>().ReverseMap();
            CreateMap<CreateContactDto, Contact>().ReverseMap();
            CreateMap<UpdateContactDto, Contact>().ReverseMap();
            CreateMap<GetByIdContactDto, Contact>().ReverseMap();
        }
    }
}
