using Ardalis.Specification.EntityFrameworkCore;
using Feedback.Infrastructure.Interfaces.Repositories;

namespace Feedback.Infrastructure.Data;

public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class
{
    public readonly ReviewContext ReviewContext;

    public EfRepository(ReviewContext reviewContext) : base(reviewContext) =>
        this.ReviewContext = reviewContext;
}