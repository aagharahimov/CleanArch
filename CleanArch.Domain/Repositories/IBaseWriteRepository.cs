using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Repositories;

public interface IBaseWriteRepository<T> where T : BaseEntity
{
	Task CreateAsync(T data);
	void Update(T data);
	void Delete(T data);
}
