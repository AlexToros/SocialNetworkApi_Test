using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialNetworkApi_Test.Controllers
{
	[ApiController]
	[Route("api/v1/[controller]")]
	public class ClientController : ControllerBase
	{
		private ClientEngine _clientEngine;

		public ClientController(ClientEngine clientEngine)
		{
			_clientEngine = clientEngine;
		}

		[HttpGet]
		[Route("{clientId}")]
		public SocialApi.Client GetClient(int clientId)
		{
			return _clientEngine.GetClient(clientId);
		}

		[HttpPost]
		public SocialApi.Client Create(SocialApi.Client.Create request)
		{
			var clientId = _clientEngine.CreateNewClient(request);
			return _clientEngine.GetClient(clientId);
		}

		[HttpGet]
		[Route("top/{limit}")]
		public List<SocialApi.Client> MostPopularClients(int limit)
		{
			return _clientEngine.GetMostPopularClients(limit);
		}

		[HttpPut]
		[Route("subscribe/{from}/{to}")]
		public void Subscribe(int from, int to)
		{
			_clientEngine.Subscribe(from, to);
		}
	}
}
