using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetworkApi_Test
{
	[Table("Clients")]
	public class ClientDao
	{
		[Key]
		public int ClientID { get; set; }
		public string Name { get; set; }

		public List<ClientDao> Subscriptions { get; set; }
		public List<ClientDao> Subscribers { get; set; }
	}
}
