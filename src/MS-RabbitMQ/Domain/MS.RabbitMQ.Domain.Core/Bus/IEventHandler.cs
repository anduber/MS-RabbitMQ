using MS.RabbitMQ.Domain.Core.Events;

namespace MS.RabbitMQ.Domain.Core.Bus;

public interface IEventHandler<in TEvent>:IEventHandler
    where TEvent : Event
{
    Task Handle(TEvent @event);
}

public interface IEventHandler
{
    
}