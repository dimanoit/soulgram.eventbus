using System.Threading.Tasks;

namespace Soulgram.Eventbus.Interfaces
{
	public interface IIntegrationEventHandler<in TIntegrationEvent> where TIntegrationEvent : IntegrationEvent
	{
		Task Handle(TIntegrationEvent @event);
	}
}