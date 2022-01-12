using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingAutomapper.Dto;
using TrainingAutomapper.Models;

namespace TrainingAutomapper.Profiles
{
    public class ClientProfile : Profile
    {
        public ClientProfile()
        {
            CreateMap<Client, ClientDto>()
                .ForMember(dest => dest.Surname, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.EmailAddress, opt => opt.MapFrom(src => src.Email));
                
        }
    }
}
