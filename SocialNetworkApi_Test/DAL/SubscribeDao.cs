using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetworkApi_Test
{
	[Table("Subscribes")]
	public class SubscribeDao
	{
		[Key]
		public int SubscriberClientId { get; set; }
		[Key]
		public int TargetClientId { get; set; }

		public ClientDao SubscriberClient { get; set; }
		public ClientDao TargetClient { get; set; }
	}
}
