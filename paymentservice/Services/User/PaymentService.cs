using contracts;

namespace paymentservice.Services.Payment;

public class PaymentService
{
    private static readonly Random _random = new Random();
    private readonly ILogger<PaymentService> _logger;

    public PaymentService(ILogger<PaymentService> logger)
    {
        _logger = logger;
    }

    public PayResponse Pay(PayRequest request)
    {
        int randomNumber = _random.Next(0, 10);
        bool paymentResult = randomNumber >= 1; // 90% chance of success

        // Log the random number and result
        _logger.LogInformation($"Random number chosen: {randomNumber}");
        _logger.LogInformation($"Payment result: {paymentResult}");

        return new PayResponse(paymentResult);
    }

}