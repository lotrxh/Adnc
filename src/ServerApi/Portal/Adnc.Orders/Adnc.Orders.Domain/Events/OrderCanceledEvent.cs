﻿using Adnc.Infr.EventBus;

namespace Adnc.Orders.Domain.Events
{
    public sealed class OrderCanceledEvent : BaseEvent<OrderCanceledEvent.EventData>
    {
        public OrderCanceledEvent(long id, EventData eventData,string eventSource)
            : base(id, eventData, eventSource)
        {
        }

        public class EventData
        {
            public long OrderId { get; set; }
        }
    }
}
