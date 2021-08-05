using System;
using System.Threading.Tasks;

namespace CastGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            IRequestHandler<Ping, string> Handler = new PingHandler();
            Console.WriteLine(Handler.Handle(new Ping()).Result);
            Object O = Handler;
            Console.WriteLine(SendHandler(new Ping(),O).Result);
        }


        static Task<T> SendHandler<T>(IRequest<T> request, object handler)
        {
            //var Handler =  handler as IRequestHandler<IRequest<T>, T>;
            var Handler = (IRequestHandler<IRequest<T>, T>)handler;        
            return Handler.Handle(request);
            //var Handler = (IRequestHandler<Ping, String>)handler;
            //var Request = request as Ping;
            //Handler.Handle(Request);
            //return default;
        }
    }
}
