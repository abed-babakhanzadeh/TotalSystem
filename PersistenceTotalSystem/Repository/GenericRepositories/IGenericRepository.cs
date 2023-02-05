namespace PersistenceTotalSystem.Repository.GenericRepositories
{
	using System.Linq.Expressions;

	public interface IGenericRepository<TEntity> where TEntity : class
	{
		Task<IEnumerable<TEntity>> Get(
			Expression<Func<TEntity, bool>> where = null,
			Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderby = null,
			string includes = "");
		//Task<IReadOnlyList<TEntity>> GetAll();
		List<TEntity> GetAlls();
		Task<bool> Add(TEntity entity);
		Task<bool> Update(TEntity entity);
		Task<bool> Delete(int id);
		Task<bool> Delete(TEntity entity);
	}
}
