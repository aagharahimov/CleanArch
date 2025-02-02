using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Repositories;

public interface IBaseReadRepository<T> where T : BaseEntity
{
	Task<List<T>> GetAllAsync();
	Task<T> GetAsync(int id);
}
