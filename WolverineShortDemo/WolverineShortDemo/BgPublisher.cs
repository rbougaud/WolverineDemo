using Microsoft.Extensions.Hosting;
using Wolverine;

namespace WolverineShortDemo;

public class BgPublisher(IMessageBus messageBus) : BackgroundService
{
    private readonly IMessageBus _messageBus = messageBus;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            await _messageBus.SendAsync(new CreateCustomer(Guid.NewGuid(), "Regis Wolverine"));
            await Task.Delay(2000, stoppingToken);
        }
    }
}

