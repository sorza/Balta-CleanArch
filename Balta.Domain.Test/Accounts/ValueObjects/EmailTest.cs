using Balta.Domain.Accounts.ValueObjects;
using Balta.Domain.Accounts.ValueObjects.Exceptions;

namespace Balta.Domain.Test.Accounts.ValueObjects
{
    public class EmailTest
    {
        [Theory]
        [InlineData("test@teste.com")]
        [InlineData("test@gmail.com")]
        [InlineData("test@outlook.com")]
        public void ShouldCreateAnEmail(string address)
        {
            var email = Email.Create(address);
            Assert.Equal(address, email.Address);
        }

        [Theory]
        [InlineData(" ")]
        [InlineData("")]
        public void ShouldFailtToCreateAnEmail(string address)
        {
            Assert.Throws<InvalidEmailLenghtException>(() =>
            {
                var email = Email.Create(address);
            });
        }

        [Theory]
        [InlineData("teste")]
        [InlineData("teste.teste")]
        public void ShouldFailtToCreateAnEmailIfAddressIsInvalid(string address)
        {
            Assert.Throws<InvalidEmailException>(() =>
            {
                var email = Email.Create(address);
            });
        }
    }
}
