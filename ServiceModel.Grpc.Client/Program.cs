using System;
using ServiceModel.Grpc.Channel;

namespace ServiceModel.Grpc.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //// create a channel
            //var channel = new Channel("localhost", 5000);

            //// create a client factory
            //var clientFactory = new ClientFactory();

            //// request the factory to generate a proxy for ICalculator service
            //var calculator = clientFactory.CreateClient<ICalculator>(channel);

            //// call Sum: sum == 6
            //var sum = await calculator.Sum(1, 2, 3);

            //// call MultiplyBy: multiplier == 2, values == [] {2, 4, 6}
            //var (multiplier, values) = await calculator.MultiplyBy(new[] { 1, 2, 3 }, 2);
        }
    }
}
