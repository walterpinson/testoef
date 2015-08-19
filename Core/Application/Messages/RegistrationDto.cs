using System;

namespace Core.Application.Messages
{
    public class RegistrationDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RespondedOn { get; set; }
    }
}
