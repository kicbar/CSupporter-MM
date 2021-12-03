using CSupporter.Shared.Abstractions.IMessages;
using CSupporter.Shared.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSupporter.Shared.Infrastructure.Messages
{
    public class RequestSender : IRequestSender
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<string> SendAsync<T>(APIRequest apiRequest)
        {
            throw new NotImplementedException();
        }
    }
}
