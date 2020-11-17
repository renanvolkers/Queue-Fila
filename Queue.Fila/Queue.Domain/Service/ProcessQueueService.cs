using Microsoft.Extensions.Logging;
using Queue.Domain.Service.Interface;
using System;
using System.Threading.Tasks;

namespace Queue.Domain
{
    public class ProcessQueueService : IProcessQueueService
    {
        public ProcessQueueService(
            ILogger<ProcessQueueService> logger,
            IQueueService serviceQueue)
        {

        }

        public Task CleamToStartProcess()
        {
            throw new NotImplementedException();
        }

        public Task ProcessQueue()
        {
            throw new NotImplementedException();
        }
    }

    }
