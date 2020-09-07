using AutoMapper;
using NgaoApi.Dtos;
using NgaoApi.Models;

namespace ngaoApi.profiles
{
    public class NgaoProfile : Profile
    {
        public NgaoProfile()
        {
            //Source -> Target
            CreateMap<ngao, NgaoReadDto>();
            CreateMap<NgaoCreateDto, ngao>();
            CreateMap<NgaoUpdateDto, ngao>();
        }
    }
}