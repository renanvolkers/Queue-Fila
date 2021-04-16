using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Domain.Service.Interface
{
    public interface IProcessQueueService
    {
        Task SetCleanConfiguration();
        Task MethodExecuteQueue();
    }
}
