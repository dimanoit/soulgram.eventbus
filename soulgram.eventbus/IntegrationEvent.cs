using System;

namespace Soulgram.Eventbus
{
	public class IntegrationEvent
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

		public Guid Id { get; set; }

		public DateTime CreationDate { get; }
	}
}
