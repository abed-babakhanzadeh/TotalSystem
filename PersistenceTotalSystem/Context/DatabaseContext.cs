using DomainTotoalSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace PersistenceTotalSystem.Context
{
	using ApplicationTotalSystem.DataBase;

	using PersistenceTotalSystem.Repository.GenericRepositories;

	public class DatabaseContext : DbContext, IDataBaseContext
	{

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=TotalSystem;Integrated Security=True;TrustServerCertificate=True;");
		}

		public DbSet<Product> Products { get; set; }


	}
}
