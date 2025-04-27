using Balta.Domain.Shared.Exceptions;

namespace Balta.Domain.Accounts.ValueObjects.Exceptions
{
    public sealed class InvalidFirstNameLenghtException(string message) : DomainException(message);
}
