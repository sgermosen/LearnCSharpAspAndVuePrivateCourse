using Contacts.Api.Dtos.Contacts;
using Contacts.Domain;

namespace Contacts.Api.Profile
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<Contact, ContactBaseDto>()
                 .ForMember(dest => dest.ContactId, opt => opt.MapFrom(src => src.Id))
                 .ReverseMap();
            CreateMap<Contact, ContactDto>()
               .ForMember(dest => dest.ContactId, opt => opt.MapFrom(src => src.Id))
               .ReverseMap();
            CreateMap<Contact, CreateContactDto>()
                 .ForMember(dest => dest.ContactId, opt => opt.MapFrom(src => src.Id))
                 .ReverseMap();
            CreateMap<Contact, UpdateContactDto>()
                 .ForMember(dest => dest.ContactId, opt => opt.MapFrom(src => src.Id))
                 .ReverseMap();
        }
    }
}
