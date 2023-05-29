namespace EnterWellTest.Infrastructure.Persistence
{
    public interface IEnterWellTestDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
