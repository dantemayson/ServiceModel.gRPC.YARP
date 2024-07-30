using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Threading;

namespace ServiceModel.Grpc.Contract
{
    [ServiceContract]
    public interface IGreeter
    {
        [OperationContract]
        Task<string> SayHelloAsync(string personFirstName, string personSecondName, CancellationToken token = default);

        [OperationContract]
        Task<string> SayHelloToAsync(Person person, CancellationToken token = default);
    }
}
