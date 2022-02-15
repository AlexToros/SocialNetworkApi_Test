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

		public ICollection<SubscribeDao> Subscriptions { get; set; }
		public ICollection<SubscribeDao> Subscribers { get; set; }
	}
}
