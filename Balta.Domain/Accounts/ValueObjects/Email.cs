using Balta.Domain.Accounts.ValueObjects.Exceptions;
using Balta.Domain.Shared.ValueObjects;
using System.Text.RegularExpressions;

namespace Balta.Domain.Accounts.ValueObjects
{
    public sealed partial record Email : ValueObject
    {
        #region Constants
        
        public const int MinLength = 6;
        public const int MaxLength = 160;        

        private const string Pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";

        #endregion

        #region Constructors

        private Email(string address)
        {
            Address = address;
        }
        #endregion

        #region Factories

        public static Email Create(string address)
        {
            if(string.IsNullOrEmpty(address)
                || string.IsNullOrWhiteSpace(address))
            {
                throw new InvalidEmailLenghtException("Email cannot be empty or null");
            }
            address = address.Trim();
            address = address.ToLower();

            if(!EmailRegex().IsMatch(address))
            {
                throw new InvalidEmailException("Invalid email format");
            }

            return new Email(address);
        }

        #endregion

        #region Properties
        public string Address { get; }
        #endregion

        #region Operators
        public static implicit operator string(Email email) => email.Address;

        #endregion

        #region Overrides
        public override string ToString() => Address;
        #endregion

        #region Source Generator
        [GeneratedRegex(Pattern)]
        private static partial Regex EmailRegex();

        #endregion
    }
}
