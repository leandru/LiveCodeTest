using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Taller.Domain;

namespace Taller.Infrastructure
{
    public class ReportRepository : IReportRepository
    {
        private EfReportDbContext _dbContext;

        public ReportRepository(EfReportDbContext dbContext ) {

            _dbContext = dbContext;
        
        }

        public Task Create(Report report)
        {
            _dbContext.Reports.AddAsync( report );
            return Task.CompletedTask;
        }

        public Task<List<Report>> GetByStatus(string status)
        {
            var statusParam = new SqlParameter("Status", status);
            var result = _dbContext.Reports.FromSql($"EXECUTE GETREPORTS {status}").ToListAsync();


            return result;

        }
    }
}
