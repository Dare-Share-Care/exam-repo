using Ardalis.Specification;

namespace Feedback.Infrastructure.Interfaces.Repositories;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class
{
}