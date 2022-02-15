using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetworkApi_Test.Core.DAL
{
	interface IClientRepository
	{
		int Create(Client newClient);
		void SaveSubscribe(Subscribe subscribe);
		List<Client> GetTopNPopularClients(int n);
	}
}
