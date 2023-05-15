using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

namespace Recipe_289 {

    public class ConsoleService : IHostedService 
    {
        private readonly IHostApplicationLifetime _applicationLifetime;
        private readonly IConfiguration _config;
        private readonly IConsoleWorker _worker;
        // このコンストラクタでDependency Injectionしている。
        public ConsoleService(IHostApplicationLifetime applicationLifetime, IConfiguration config, IConsoleWorker worker) 
        {
            _applicationLifetime = applicationLifetime;
            _config = config;
            _worker = worker;
        }

        public async Task StartAsync(CancellationToken cancellationToken) 
        {
            await _worker.Run();
            // 次の1行がないとプログラムが終わらない
            _applicationLifetime.StopApplication();
            //return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken) 
        {
            return Task.CompletedTask;
        }
    }

    public interface IConsoleWorker 
    {
        Task Run();
    }
}


