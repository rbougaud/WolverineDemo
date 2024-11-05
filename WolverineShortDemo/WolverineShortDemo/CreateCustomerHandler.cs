using Microsoft.Extensions.Logging;

namespace WolverineShortDemo;

public class CreateCustomerHandler(ILogger<CreateCustomerHandler> logger)
{
    private readonly ILogger<CreateCustomerHandler> _logger = logger;

    public CustomerCreated Handle(CreateCustomer createCustomer)
    {
        _logger.LogInformation(createCustomer.ToString()); // A ne pas faire dans les logs => voir avec @
        return new(createCustomer.Id, createCustomer.FullName);
    }
}
