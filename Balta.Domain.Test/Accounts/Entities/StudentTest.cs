using Balta.Domain.Accounts.Entities;
using Balta.Domain.Accounts.ValueObjects;
using Balta.Domain.Shared.Abstractions;
using Balta.Domain.Test.Mocks;

namespace Balta.Domain.Test.Accounts.Entities
{
    public class StudentTest
    {
        private readonly IDateTimeProvider _dateTimeProvider = new FakeDateTimeProvider();

        [Fact]
        public void ShouldRaiseOnStudentCreatedEventPrimitive()
        {
            var student = Student.Create("Alexandre", "Zordan", "alexandre.sorza@teste.com", _dateTimeProvider);
            Assert.Single(student.Events);
        }

        [Fact]
        public void ShouldRaiseOnStudentCreatedEvent()
        {
            var name = Name.Create("Alexandre", "Zordan");
            var email = Email.Create("teste@teste.com");
            var student = Student.Create(name,email, _dateTimeProvider);
            Assert.Single(student.Events);
        }
    }
}
