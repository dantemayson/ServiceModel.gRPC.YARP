using ServiceModel.Grpc.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceModel.Grpc.Service
{
    internal sealed class Greeter : IGreeter
    {
        public Task<string> SayHelloAsync(string personFirstName, string personSecondName, CancellationToken token)
        {
            return Task.FromResult(string.Format("Hello {0} {1}", personFirstName, personSecondName));
        }

        public Task<string> SayHelloToAsync(Person person, CancellationToken token)
        {
            return Task.FromResult(string.Format("Hello {0} {1}", person.FirstName, person.SecondName));
        }
    }
}
