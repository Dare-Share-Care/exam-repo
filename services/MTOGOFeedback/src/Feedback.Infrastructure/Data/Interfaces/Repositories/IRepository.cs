using Ardalis.Specification;

namespace Feedback.Infrastructure.Interfaces.Repositories;

public interface IRepository<T> : IRepositoryBase<T> where T : class
{
}