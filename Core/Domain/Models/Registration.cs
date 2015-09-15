using System;

namespace Core.Domain.Models
{
    public class Registration
    {
        public Guid Id { get; set; }
        public DateTime RespondedOn { get; private set; }
        public Name Name { get; set; }
        public string Message { get; set; }
        public bool IsRegistered { get; private set; }

        public void Register()
        {
            RespondedOn = DateTime.Now;
            IsRegistered = true;
        }
    }
}
