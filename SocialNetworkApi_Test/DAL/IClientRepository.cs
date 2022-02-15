using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetworkApi_Test
{
	public interface IClientRepository
	{
		int Create(ClientDao newClient);
		ClientDao Get(int clientId);
		void SaveSubscribe(SubscribeDao subscribe);
		List<ClientDao> GetTopNPopularClients(int n);
	}
}
