﻿using MediatR;

namespace MS.RabbitMQ.Domain.Core.Events;

public abstract class Message:IRequest<bool>
{
    public string MessageType { get; protected set; }

    public Message()
    {
        MessageType = GetType().Name;
    }
}