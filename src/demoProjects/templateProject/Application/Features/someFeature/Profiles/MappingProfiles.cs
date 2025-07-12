using AutoMapper;
using Application.Features.someFeature.Dtos;
using Application.Features.someFeature.Commands.CreateSomeFeature;
using Domain.Entities;

namespace Application.Features.someFeature.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<SomeFeatureEntity, CreatedSomeFeatureEntityDto>().ReverseMap();
            CreateMap<SomeFeatureEntity, CreateSomeFeatureEntityCommand>().ReverseMap();
        }
    }
}
