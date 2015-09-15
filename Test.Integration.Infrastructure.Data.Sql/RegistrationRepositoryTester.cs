using System;
using Core.Domain.Models;
using Infrastructure.Data.Sql;
using NUnit.Framework;

namespace Test.Integration.Infrastructure.Data.Sql
{
    [TestFixture]
    public class RegistrationRepositoryTester
    {
        private RegistrationRepository _subjectUnderTest;
        private Registration _registration;

        [SetUp]
        public void SetUp()
        {
            var connectionStringName = "test";
            _subjectUnderTest = new RegistrationRepository(connectionStringName);
        }

        [TearDown]
        public void TearDown()
        {
            _registration = null;
            _subjectUnderTest = null;
        }

        [Test]
        public void CanAddRegistration()
        {
            // ARRANGE
            _registration = CreateRegistration();

            // ACT
            var newRegistration = _subjectUnderTest.Add(_registration);

            // ASSERT
            Assert.That(newRegistration.Id, Is.Not.EqualTo(Guid.Empty));
        }

        [Test]
        public void CanRetrieveRegistrations()
        {
            // ARRANGE

            // ACT
            var registrations = _subjectUnderTest.Get();

            // ASSERT
            Assert.That(registrations.Count, Is.Not.EqualTo(0));
        }

        private Registration CreateRegistration()
        {
            var name = new Name
            {
                First = "John",
                Last = "Doe"
            };

            var registration = new Registration
            {
                Id = Guid.Empty,
                Name = name,
                Message = $"Thank you for hosting this event!"
            };

            return registration;
        }
    }
}
