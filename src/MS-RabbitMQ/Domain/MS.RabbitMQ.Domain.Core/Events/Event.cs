namespace MS.RabbitMQ.Domain.Core.Events;

public abstract class Event
{
    public DateTime TimeStamp { get; set; }

    protected Event()
    {
        TimeStamp = DateTime.Now;
    }
}