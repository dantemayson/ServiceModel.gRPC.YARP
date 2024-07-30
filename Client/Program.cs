using Contract;
using Grpc.Core;
using ServiceModel.Grpc.Client;
using System;
using System.Threading.Tasks;

namespace Client
{
    public static class Program
    {
        private static readonly IClientFactory DefaultClientFactory = new ClientFactory();
        public static async Task Main(string[] args)
        {
            // create gRPC channel
            Channel channel = new Channel("localhost", 9988, ChannelCredentials.Insecure);

            // create IGreeter client proxy
            var client = DefaultClientFactory.CreateClient<IGreeter>(channel);

            var person = new Person { FirstName = "mehdi", SecondName = "alan" };

            var greet1 = await client.SayHelloAsync(person.FirstName, person.SecondName);
            Console.WriteLine(greet1);

            var greet2 = await client.SayHelloToAsync(person);
            Console.WriteLine(greet2);
            Console.ReadKey();
        }
    }
}
