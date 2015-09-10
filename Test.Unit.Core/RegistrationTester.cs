using System;
using Core.Domain.Models;
using NUnit.Framework;

namespace Test.Unit.Core
{
    [TestFixture]
    public class RegistrationTester
    {
        public void CanSetId()
        {
            // ARRANGE
            var expectedId = Guid.NewGuid();
            var subjectUnderTest = new Registration();

            // ACT
            subjectUnderTest.Id = expectedId;

            // ASSERT
            Assert.That(subjectUnderTest.Id, Is.EqualTo(expectedId));
        }
    }
}
