using System;
using System.Collections.Generic;

namespace Soulgram.Eventbus.Interfaces
{
    public interface IEventBusSubscriptionsManager
	{
		bool IsEmpty { get; }
		event EventHandler<string> OnEventRemoved;

		void AddSubscription<T, TH>()
			where T : IntegrationEvent
			where TH : IIntegrationEventHandler<T>;

		void RemoveSubscription<T, TH>()
			where TH : IIntegrationEventHandler<T>
			where T : IntegrationEvent;

		bool HasSubscriptionsForEvent<T>() where T : IntegrationEvent;
		bool HasSubscriptionsForEvent(string eventName);

		IEnumerable<Type> GetHandlersForEvent<T>() where T : IntegrationEvent;
		IEnumerable<Type> GetHandlersForEvent(string eventName);

		Type GetEventTypeByName(string eventName);
		void Clear();

		string GetEventKey<T>();
	}
}