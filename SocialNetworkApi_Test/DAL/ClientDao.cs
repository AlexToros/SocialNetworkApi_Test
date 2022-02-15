using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetworkApi_Test
{
	public class ClientDao
	{
		public int ClientID { get; set; }
		public string Name { get; set; }

		public List<ClientDao> Subscriptions { get; set; }
		public List<ClientDao> Subscribers { get; set; }
	}
}
