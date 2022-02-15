using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetworkApi_Test
{
	public class StoreSettings
	{
		public string DbName { get; set; }
		public string RootFolder { get; set; }
		public string DbPath { get; set; }

		public StoreSettings Bind(IConfigurationSection section)
		{
			section.Bind(this);
			var folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), RootFolder);

			if (!Directory.Exists(folderPath))
				Directory.CreateDirectory(folderPath);

			DbPath = Path.Combine(folderPath, DbName);

			return this;
		}
	}
}
