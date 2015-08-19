using System.Collections.Generic;
using AutoMapper;
using Core.Application.Messages;
using Core.Domain.Models;

namespace Infrastructure.Server
{
    public class DtoMapper
    {
        public static void Configure()
        {
            Mapper.CreateMap<Registration, RegistrationDto>()
                .ForMember(dto => dto.Id, conf => conf.MapFrom(registration => registration.Id))
                .ForMember(dto => dto.FirstName, conf => conf.MapFrom(registration => registration.Name.First))
                .ForMember(dto => dto.LastName, conf => conf.MapFrom(registration => registration.Name.Last))
                .ForMember(dto => dto.RespondedOn, conf => conf.MapFrom(registration => registration.RespondedOn));
        }
    }
}
