namespace PersistenceTotalSystem.Repository.GenericRepositories
{
	using System.Linq;
	using System.Linq.Expressions;
	using System.Threading.Tasks;
	using ApplicationTotalSystem.DataBase;
	using Microsoft.EntityFrameworkCore;

	public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class

	{
		private readonly IDataBaseContext _context;

		private DbSet<TEntity> _dbset;

		public GenericRepository(IDataBaseContext context)
		{
			_context = context;
			_dbset = context.Set<TEntity>();
		}

		//public virtual IEnumerable<TEntity> Get(
		//	Expression<Func<TEntity, bool>> where = null,
		//	Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderby = null,
		//	string includes = "")
		//{
		//	IQueryable<TEntity> query = _dbset;

		//	if (where != null)
		//	{
		//		query = query.Where(where);
		//	}

		//	if (orderby != null)
		//	{
		//		query = orderby(query);
		//	}

		//	if (includes != "")
		//	{
		//		foreach (string include in includes.Split(','))
		//		{
		//			query = query.Include(include);
		//		}
		//	}

		//	return query.ToList();
		//}

		public virtual TEntity GetById(object id)
		{
			return _dbset.Find(id);
		}

		//public virtual IEnumerable<TEntity> GetAll()
		//{
		//	return _dbset.ToList();
		//}

		//public virtual void Insert(TEntity entity)
		//{
		//	_dbset.Add(entity);
		//}

		//public virtual void Update(TEntity entity)
		//{
		//	_dbset.Attach(entity);
		//	_context.Entry(entity).State = EntityState.Modified;
		//}

		//public virtual void Delete(TEntity entity)
		//{
		//	if (_context.Entry(entity).State == EntityState.Detached)
		//	{
		//		_dbset.Attach(entity);
		//	}

		//	_dbset.Remove(entity);
		//}

		//public virtual void Delete(object id)
		//{
		//	var entity = GetById(id);
		//	Delete(entity);
		//}

		public virtual void Save()
		{
			_context.SaveChanges();
		}

		public List<TEntity> GetAlls()
		{
			return _dbset.ToList();

		}

		public async Task<bool> Add(TEntity entity)
		{
			_dbset.Add(entity);
			return true;
		}

		async Task<bool> IGenericRepository<TEntity>.Update(TEntity entity)
		{
			_dbset.Attach(entity);
			_context.Entry(entity).State = EntityState.Modified;
			return true;
		}

		public async Task<bool> Delete(object id)
		{
			var entity = GetById(id);
			Delete(entity);
			return true;
		}

		public async Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> where = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderby = null, string includes = "")
		{
			
			IQueryable<TEntity> query = _dbset;

			if (where != null)
			{
				query = query.Where(where);
			}

			if (orderby != null)
			{
				query = orderby(query);
			}

			if (includes != "")
			{
				foreach (string include in includes.Split(','))
				{
					query = query.Include(include);
				}
			}

			return query.ToList();
			
		}

		public Task<bool> Delete(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> Delete(TEntity entity)
		{
			if (_context.Entry(entity).State == EntityState.Detached)
			{
				_dbset.Attach(entity);
			}

			_dbset.Remove(entity);
			return true;
		}
	}
}
