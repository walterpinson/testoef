using System;
using System.Collections;
using System.Collections.Generic;
using Core.Domain.Models;

namespace Core.Domain.Services
{
    public interface IRegistrationRepository
    {
        IList<Registration> Get();
        Registration Get(Guid id);
        Registration Add(Registration registration);
    }
}
