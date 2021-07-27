using System;

namespace Soulgram.Eventbus
{
	public record IntegrationEvent
	{
		public IntegrationEvent()
		{
			Id = Guid.NewGuid();
			CreationDate = DateTime.UtcNow;
		}

		public IntegrationEvent(Guid id, DateTime createDate)
		{
			Id = id;
			CreationDate = createDate;
		}

		public Guid Id { get; }

		public DateTime CreationDate { get; }
	}
}
