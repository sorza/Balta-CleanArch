using Balta.Domain.Shared.Exceptions;

namespace Balta.Domain.Accounts.ValueObjects.Exceptions
{
    public sealed class InvalidEmailLenghtException(string message): DomainException(message);
}
