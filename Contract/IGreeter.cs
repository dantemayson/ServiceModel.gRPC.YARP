﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Contract
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
