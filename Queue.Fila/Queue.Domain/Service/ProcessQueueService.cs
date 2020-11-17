using Microsoft.Extensions.Logging;
using Queue.Domain.Service.Interface;
using System;
using System.Threading.Tasks;

namespace Queue.Domain
{
    public class ProcessQueueService : IProcessQueueService
    {
        private ILogger<ProcessQueueService> _Logger;
        public ProcessQueueService(
            ILogger<ProcessQueueService> logger,
            IQueueService serviceQueue)
        {
            _Logger = logger;
        }

        public Task CleamToStartProcess()
        {
            try
            {
                await _MinimumTargetUploadCsvRepository.SetErrorFilesProcessing();
                _Logger.LogInformation("CleamToStartProcess SUCESS");
            }
            catch (Exception ex)
            {
                _Logger.LogCritical(ex, "ERRO AO EXECUTAR O CleamToStartProcess");
                throw ex;
            }
        }

        public Task ProcessQueue()
        {
            throw new NotImplementedException();
        }
    }

    }
