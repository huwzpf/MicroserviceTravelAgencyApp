namespace transportservice.Services.Transport;

public class InMemoryEventBus : IEventBus
{
    private readonly Dictionary<Type, List<Action<object>>> _handlers = new();

    public void Publish<TEvent>(TEvent @event) where TEvent : class
    {
        var eventType = typeof(TEvent);
        if (_handlers.TryGetValue(eventType, out var handler1))
        {
            foreach (var handler in handler1)
            {
                handler(@event);
            }
        }
    }

    public void Subscribe<TEvent>(Action<TEvent> handler) where TEvent : class
    {
        var eventType = typeof(TEvent);
        if (!_handlers.ContainsKey(eventType))
        {
            _handlers[eventType] = new List<Action<object>>();
        }
        _handlers[eventType].Add(e => handler((TEvent)e));
    }
}