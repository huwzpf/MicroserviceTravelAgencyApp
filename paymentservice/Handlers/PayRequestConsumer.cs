using contracts;
using MassTransit;
using paymentservice.Services.Payment;

namespace paymentservice.Handlers;

public class PayRequestConsumer : IConsumer<PayRequest>
{
    private readonly ILogger<PayRequestConsumer> _logger;
    private readonly PaymentService _paymentService;
    public PayRequestConsumer(ILogger<PayRequestConsumer> logger, PaymentService paymentService)
    {
        _logger = logger;
        _paymentService = paymentService;
    }
    
    public async Task Consume(ConsumeContext<PayRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(PayRequestConsumer), context.Message);
        await context.RespondAsync(_paymentService.Pay(context.Message));
    }
}