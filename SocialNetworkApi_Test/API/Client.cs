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
			public Client() { }
			public Client(ClientDao client)
			{
				Id = client.ClientID;
				Name = client.Name;

				Subscribers = client.Subscribers?
					.Where(x => x.SubscriberClient != null)
					.Select(x => new Client { Id = x.SubscriberClient.ClientID, Name = x.SubscriberClient.Name }).ToList();
				Subscriptions = client.Subscriptions?
					.Where(x => x.TargetClient != null)
					.Select(x => new Client { Id = x.TargetClient.ClientID, Name = x.TargetClient.Name }).ToList();
			}

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
