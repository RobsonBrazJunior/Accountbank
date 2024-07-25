namespace Accountbank.Infra.Data.Repository.Interfaces;

public interface IGenericRepository<T> where T : class
{
	T GetById(Guid id);
	IEnumerable<T> GetAll();
	void Add(T entity);
	void Update(T entity);
	void Remove(T entity);
}
