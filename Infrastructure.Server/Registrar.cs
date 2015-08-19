using System;
using System.Collections.Generic;
using AutoMapper;
using Core.Application.Messages;
using Core.Application.Services;
using Core.Domain.Models;
using Core.Domain.Services;

namespace Infrastructure.Server
{
    public class Registrar : IRegistrar
    {
        private readonly IRegistrationRepository _registrationRepository;

        public Registrar(IRegistrationRepository registrationRepository)
        {
            _registrationRepository = registrationRepository;
        }

        public RegistrationDto Rsvp(NewAcceptanceMessage message)
        {
            var name = new Name {First = message.FirstName, Last = message.LastName};
            var registration = new Registration
            {
                Id = Guid.Empty,
                Message = message.Message,
                Name = name,
                RespondedOn = DateTime.Now
            };

            _registrationRepository.Add(registration);

            return Mapper.Map<RegistrationDto>(registration);
        }

        public IList<RegistrationDto> GetRegistrations()
        {
            var registrations = _registrationRepository.Get();

            return Mapper.Map<IList<RegistrationDto>>(registrations);
        }
    }
}
