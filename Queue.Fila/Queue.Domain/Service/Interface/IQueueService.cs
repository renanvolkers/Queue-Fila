using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Domain.Service.Interface
{
    public interface IQueueService
    {
        Task<QueueClient> GetQueue();
        Task SendMessage(string message);
        Task DeleteMessage(QueueMessage message);
        Task<IEnumerable<QueueMessage>> GetMessages();
    }
}
