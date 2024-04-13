
using MessageToUser.Interface;

namespace MessageToUser.Service
{
    public class MainBackgroundService(IWork work) : BackgroundService
    {
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            work.Execute();
            return Task.CompletedTask;
        }
    }
}
