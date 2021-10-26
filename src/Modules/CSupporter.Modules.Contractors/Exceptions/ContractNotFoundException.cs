using CSupporter.Shared.Abstractions.Exceptions;
using System;

namespace CSupporter.Modules.Contractors.Exceptions
{
    internal class ContractNotFoundException : CSupporterException
    {
        public Guid Id { get; }

        public ContractNotFoundException(Guid id) : base(message: $"Contract with ID '{id}' was not found.")
        {
            Id = id;
        }
    }
}
