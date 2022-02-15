using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetworkApi_Test
{
	public class EFClientRepository : IClientRepository
	{
		private readonly ClientContext _dbContext;

		public EFClientRepository(ClientContext dbContext)
		{
			_dbContext = dbContext;
		}

		public int Create(ClientDao newClient)
		{
			_dbContext.Clients.Add(newClient);
			_dbContext.SaveChanges();
			return newClient.ClientID;
		}

		public ClientDao Get(int clientId)
		{
			return _dbContext.Clients
				.Include(x => x.Subscribers).ThenInclude<ClientDao, SubscribeDao, ClientDao>(x => x.SubscriberClient)
				.Include(x => x.Subscriptions).ThenInclude<ClientDao, SubscribeDao, ClientDao>(x => x.TargetClient)
				.SingleOrDefault(x => x.ClientID == clientId);
		}

		public List<ClientDao> GetTopNPopularClients(int n)
		{
			return _dbContext.Clients
				.Include(x => x.Subscribers)
				.OrderByDescending(x => x.Subscribers.Count)
				.Take(n)
				.ToList();
		}

		public void SaveSubscribe(SubscribeDao subscribe)
		{
			_dbContext.Subscribes.Add(subscribe);
			_dbContext.SaveChanges();
		}
	}
}
