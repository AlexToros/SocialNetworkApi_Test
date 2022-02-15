using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetworkApi_Test
{
	public class Subscribe
	{
		public int SubscriberClientId { get; set; }
		public int TargetClientId { get; set; }

		public Client SubscriberClient { get; set; }
		public Client TargetClient { get; set; }
	}
}
