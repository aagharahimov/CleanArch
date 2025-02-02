using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Repositories;

public interface IProductReadRepository : IBaseReadRepository<Product>
{
	Task<Product> GetByNameAsync(string name);
}
