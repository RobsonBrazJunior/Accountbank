using Accountbank.Infra.Data.Context;
using Accountbank.Infra.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Accountbank.Infra.Data.Repository.Repositories;

public class GenericRepository<T>(ApplicationContext context) : IGenericRepository<T> where T : class
{
	private readonly ApplicationContext _context = context;

	public void Add(T entity)
	{
		_context.Set<T>().Add(entity);
	}

	public IEnumerable<T> GetAll()
	{
		return [.. _context.Set<T>()];
	}

	public T GetById(Guid id)
	{
		return _context.Set<T>().Find(id);
	}

	public void Update(T entity)
	{
		_context.Set<T>().Attach(entity);
		_context.Entry(entity).State = EntityState.Modified;
	}

	public void Remove(T entity)
	{
		_context.Set<T>().Remove(entity);
	}
}
