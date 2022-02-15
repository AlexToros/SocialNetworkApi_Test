using System.ComponentModel.DataAnnotations.Schema;

namespace SocialNetworkApi_Test
{
	[Table("Subscribes")]
	public class SubscribeDao
	{
		public int SubscriberClientId { get; set; }
		public int TargetClientId { get; set; }

		public ClientDao SubscriberClient { get; set; }
		public ClientDao TargetClient { get; set; }
	}
}
