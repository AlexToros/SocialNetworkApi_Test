using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetworkApi_Test
{
	public class ClientContext : DbContext
	{
		private readonly StoreSettings _storeSettings;

		public DbSet<ClientDao> Clients { get; set; }
		public DbSet<SubscribeDao> Subscribes { get; set; }

		public ClientContext(StoreSettings storeSettings)
		{
			_storeSettings = storeSettings;

			Database.EnsureDeleted();
			Database.EnsureCreated();
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<SubscribeDao>()
				.HasKey(x => new { x.SubscriberClientId, x.TargetClientId });

			modelBuilder.Entity<SubscribeDao>()
				.HasOne(x => x.SubscriberClient)
				.WithMany(x => x.Subscriptions)
				.HasForeignKey(x => x.SubscriberClientId);

			modelBuilder.Entity<SubscribeDao>()
				.HasOne(x => x.TargetClient)
				.WithMany(x => x.Subscribers)
				.HasForeignKey(x => x.TargetClientId);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite($"Data Source={_storeSettings.DbPath}");
		}
	}
}
