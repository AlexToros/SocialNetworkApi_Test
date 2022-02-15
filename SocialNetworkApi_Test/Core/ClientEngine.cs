using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialNetworkApi_Test
{
	public class ClientEngine
	{
		private readonly IClientRepository _clientRepo;
		private readonly ClientValidator _validator;

		public ClientEngine(IClientRepository clientRepo, ClientValidator validator)
		{
			_clientRepo = clientRepo;
			_validator = validator;
		}

		public int CreateNewClient(SocialApi.Client.Create request)
		{
			if (_validator.CreationInvalid(request))
				throw new Exception("Invalid client create request");

			var newClient = new ClientDao
			{
				Name = request.Name
			};

			var newId = _clientRepo.Create(newClient);

			return newId;
		}

		public SocialApi.Client GetClient(int clientId)
		{
			var client = _clientRepo.Get(clientId);

			return new SocialApi.Client(client);
		}

		public List<SocialApi.Client> GetMostPopularClients(int limit)
		{
			var popularClients = _clientRepo.GetTopNPopularClients(limit);

			return popularClients.Select(x => new SocialApi.Client(x)).ToList();
		}

		public void Subscribe(int from, int to)
		{
			if(from == to)
				throw new Exception("Trying to self subscribe");

			_clientRepo.SaveSubscribe(new SubscribeDao
			{
				SubscriberClientId = from,
				TargetClientId = to
			});
		}
	}
}
