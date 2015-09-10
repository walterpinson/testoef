using System;
using Core.Domain.Models;
using NUnit.Framework;

namespace Test.Unit.Core
{
    [TestFixture]
    public class RegistrationTester
    {
        [Test]
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

        [Test]
        public void CanSetRespondedOn()
        {
            // ARRANGE
            var expectedRespondedOn = DateTime.Now;
            var subjectUnderTest = new Registration();

            // ACT
            subjectUnderTest.RespondedOn = expectedRespondedOn;

            // ASSERT
            Assert.That(subjectUnderTest.RespondedOn, Is.EqualTo(expectedRespondedOn));
        }
    }
}
