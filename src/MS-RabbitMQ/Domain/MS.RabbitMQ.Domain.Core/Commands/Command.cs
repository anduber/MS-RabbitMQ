using MS.RabbitMQ.Domain.Core.Events;

namespace MS.RabbitMQ.Domain.Core.Commands;

public abstract class Command:Message
{
    public DateTime TimeStamp { get; protected set; }

    protected Command()
    {
        TimeStamp = DateTime.Now;
    }
}