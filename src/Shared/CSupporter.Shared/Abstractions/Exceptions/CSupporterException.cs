using System;

namespace CSupporter.Shared.Abstractions.Exceptions
{
    public abstract class CSupporterException : Exception
    {
        protected CSupporterException(string message) : base(message)
        {

        }
    }
}
