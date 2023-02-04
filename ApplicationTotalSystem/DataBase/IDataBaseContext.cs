namespace ApplicationTotalSystem.DataBase
{
	using DomainTotoalSystem.Entities;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.ChangeTracking;

	public interface IDataBaseContext
	{
		public int SaveChanges();
		public DbSet<TEntity> Set<TEntity>() where TEntity : class;
		public EntityEntry<TEntity> Entry<TEntity>(TEntity entity)
			where TEntity : class;
		public EntityEntry Entry(object entity);

		//------------------------------------------------------
		public DbSet<Product> Products { get; set; }

	}
}
