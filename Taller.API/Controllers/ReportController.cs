using Microsoft.AspNetCore.Mvc;
using Taller.Domain;

namespace Taller.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private IReportRepository _reportRepository;

        public ReportController(IReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
            
        }

        [HttpGet]
        public async Task<List<Report>> GetReports(string status)
        {
           var reports =  await _reportRepository.GetByStatus(status);
           return reports;

        }

    }
}
