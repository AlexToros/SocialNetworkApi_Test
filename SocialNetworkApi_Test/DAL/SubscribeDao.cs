using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetworkApi_Test
{
	public class SubscribeDao
	{
		public int SubscriberClientId { get; set; }
		public int TargetClientId { get; set; }

		public ClientDao SubscriberClient { get; set; }
		public ClientDao TargetClient { get; set; }
	}
}
