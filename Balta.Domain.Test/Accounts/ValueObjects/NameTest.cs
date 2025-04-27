using Balta.Domain.Accounts.ValueObjects;
using Balta.Domain.Accounts.ValueObjects.Exceptions;

namespace Balta.Domain.Test.Accounts.ValueObjects
{
    public class NameTest
    {
        private readonly Name _name = Name.Create("Alexandre", "Zordan");
        [Fact]
        public void ShouldOverrideToStringMethod()
        {           
            Assert.Equal("Alexandre Zordan", _name.ToString());
        }

        [Fact]
        public void ShouldImplicitConvertToString()
        {           
            string data = _name;
            Assert.Equal("Alexandre Zordan", data);
        }

        [Fact]
        public void ShouldCreateNewName()
        {
            var name = Name.Create("Alexandre", "Zordan");
            Assert.Equal("Alexandre Zordan", name.ToString());
        }

        [Fact]
        public void ShouldFailIfFirstNameLenghtIsInvalid()
        {
            Assert.Throws<InvalidFirstNameLenghtException>(() =>
            {
                var name = Name.Create("Al", "Zordan");
            });
        }

        [Fact]
        public void ShouldFailIfLastNameLenghtIsInvalid()
        {
            Assert.Throws<InvalidLastNameLenghtException>(() =>
            {
                var name = Name.Create("Alexandre", "Zo");
            });
        }
    }
}
