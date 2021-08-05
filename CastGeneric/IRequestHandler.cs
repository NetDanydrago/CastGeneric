using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastGeneric
{
    public interface IRequestHandler<T1,T2> where T1 : IRequest<T2>
    {
        Task<T2> Handle(T1 request);  
    }
}
