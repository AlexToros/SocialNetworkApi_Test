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

		[HttpPost]
		public void Create(SocialApi.Client.Create request)
		{
			_clientEngine.CreateNewClient(request);
		}

		[HttpGet]
		[Route("top/{limit}")]
		public List<SocialApi.Client.Create> MostPopularClients(int limit)
		{
			return _clientEngine.GetMostPopularClients(limit);
		}

		[HttpPut]
		[Route("subscribe/{from}/{to}")]
		public List<SocialApi.Client.Create> Subscribe(int from, int to)
		{
			return _clientEngine.Subscribe(from, to);
		}
	}
}
