using Microsoft.Extensions.Logging;
using Queue.Domain.Service.Interface;
using System;
using System.Threading.Tasks;

namespace Queue.Domain
{
    public class ProcessQueueService : IProcessQueueService
    {
        private readonly ILogger<ProcessQueueService> _Logger;
        public ProcessQueueService(
            ILogger<ProcessQueueService> logger,
            IQueueService serviceQueue)
        {
            _Logger = logger;
        }

        public Task SetCleanConfiguration()
        {
            try
            {
                await _WeatherForecastUploadFileRepository.UpdateErrorQueue();
                _Logger.LogInformation("Configuration is OK");
            }
            catch (Exception ex)
            {
                _Logger.LogCritical(ex, "Configuration Fail!!");
                throw;
            }
        }

        public Task MethodExecuteQueue()
        {
            throw new NotImplementedException();
        }
    }

    }
