using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationTotalSystem.DataBase
{
	using System.Data.Entity;

	using DomainTotoalSystem.Entities;

	public interface IDataBaseContext
	{
		public DbSet<Product> Products { get; set; }
		public int SaveChanges();
	}
}
