using System;

namespace Core.Domain.Models
{
    public class Registration
    {
        public Guid Id { get; set; }
        public DateTime RespondedOn { get; set; }
        public Name Name { get; set; }
        public string Message { get; set; }
    }
}
