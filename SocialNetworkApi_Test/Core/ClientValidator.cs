using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetworkApi_Test
{
	public class ClientValidator
	{
		public bool CreationInvalid(SocialApi.Client.Create request)
		{
			if (request?.Name == null)
				return true;

			if (!request.Name.All(x => Char.IsLetter(x) || x == ' '))
				return true;

			if (request.Name.Length > 64)
				return true;

			return false;
		}
	}
}
