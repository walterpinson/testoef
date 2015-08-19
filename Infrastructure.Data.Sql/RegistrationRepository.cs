using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Core.Domain.Models;
using Core.Domain.Services;

namespace Infrastructure.Data.Sql
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private readonly ApplicationContext _dbContext;
        private readonly DbSet<Registration> _registrations;

        public RegistrationRepository(string connectionStringName)
        {
            _dbContext = new ApplicationContext(connectionStringName);
            _registrations = _dbContext.Registrations;
        }
        public IList<Registration> Get()
        {
            return _registrations.ToList();
        }

        public Registration Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Registration Add(Registration registration)
        {
            var addedRegistration = _registrations.Add(registration);
            _dbContext.SaveChanges();
            return addedRegistration;
        }
    }
}
