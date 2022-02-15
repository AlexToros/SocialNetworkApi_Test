using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetworkApi_Test
{
	public partial class SocialApi
	{
		public class Client
		{
			public int Id { get; set; }
			public string Name { get; set; }

			public List<Client> Subscriptions { get; set; }
			public List<Client> Subscribers { get; set; }

			public class Create
			{
				public string Name { get; set; }
			}
		}
	}
}
