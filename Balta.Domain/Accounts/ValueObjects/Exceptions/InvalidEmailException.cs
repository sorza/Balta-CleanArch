﻿using Balta.Domain.Shared.Exceptions;

namespace Balta.Domain.Accounts.ValueObjects.Exceptions
{
    public sealed class InvalidEmailException(string message): DomainException(message);   
}
