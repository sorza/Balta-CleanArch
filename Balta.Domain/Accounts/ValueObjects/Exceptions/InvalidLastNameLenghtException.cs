using Balta.Domain.Shared.Exceptions;

namespace Balta.Domain.Accounts.ValueObjects.Exceptions
{
    public sealed class InvalidLastNameLenghtException(string message) : DomainException(message);
}
