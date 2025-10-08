namespace Taller.Domain
{
    public interface IReportRepository
    {
        Task<List<Report>> GetByStatus(string status);

        Task Create( Report report );
    }
}
