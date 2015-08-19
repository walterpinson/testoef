using System.Collections.Generic;
using Core.Application.Messages;

namespace Core.Application.Services
{
    public interface IRegistrar
    {
        RegistrationDto Rsvp(NewAcceptanceMessage message);
        IList<RegistrationDto> GetRegistrations();
    }
}
