using CORE.Extension;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Queue.API
{
    public static class Global
    {
        private static readonly DateTime startApi = DateTime.Now.ToBrasiliaTimeZone();
        public static void StartBackgroundProcess(ServiceProvider provider)
        {
            var service = provider.GetService<IProcessQueueService>();

            service.CleamToStartProcess().GetAwaiter().GetResult();
            Task.Run(() => service.ProcessQueue().GetAwaiter().GetResult());
        }

    }
}
