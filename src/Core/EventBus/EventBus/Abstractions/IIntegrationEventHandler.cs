﻿using VDS.Core.EventBus.Events;
using System.Threading.Tasks;

namespace VDS.Core.EventBus.Abstractions
{
    public interface IIntegrationEventHandler<in TIntegrationEvent> : IIntegrationEventHandler 
        where TIntegrationEvent: IntegrationEvent
    {
        Task Handle(TIntegrationEvent @event);
    }

    public interface IIntegrationEventHandler
    {
    }
}
