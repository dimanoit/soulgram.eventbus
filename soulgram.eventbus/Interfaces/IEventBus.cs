namespace Soulgram.Eventbus.Interfaces
{
    public interface IEventBus
	{
		void Publish(IntegrationEvent @event);
		void Publish(byte[] content, string eventName);
		
		void Subscribe<T, TH>()
			where T : IntegrationEvent
			where TH : IIntegrationEventHandler<T>;

		void Unsubscribe<T, TH>()
			where TH : IIntegrationEventHandler<T>
			where T : IntegrationEvent;
	}
}
