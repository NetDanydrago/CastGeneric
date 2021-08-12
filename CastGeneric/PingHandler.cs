using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastGeneric
{
    public class PingHandler : IRequestHandler<Ping, string> 
    {
        public Task<string> Handle(IRequest<string> request)
        {
            return Task.FromResult("pong");
        }
    }
}
