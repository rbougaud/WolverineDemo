using Microsoft.Extensions.Logging;

namespace WolverineShortDemo;

public class CustomerCreatedHandler(ILogger<CustomerCreatedHandler> logger)
{
    private readonly ILogger<CustomerCreatedHandler> _logger = logger;

    public void Handle(CustomerCreated customerCreated)
    {
        _logger.LogInformation(customerCreated.ToString()); // A ne pas faire dans les logs => voir avec @
    }
}
