using System;
using System.Threading.Tasks;

namespace CastGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            IRequestHandler<IRequest<string>, string> Handler =  new PingHandler();

            Object O = Handler;
            Console.WriteLine(SendHandler<Ping,string>(new Ping(),O).Result);

        }

        static Task<T> SendHandler<U,T>(U request, object handler) where U : IRequest<T>
        {
            var Handler = (IRequestHandler<IRequest<T>,T>) handler;
            return Handler.Handle(request); 
            //var Handler = (IRequestHandler<Ping, String>)handler;
            //Handler.Handle(Request);
        }
    }
}
