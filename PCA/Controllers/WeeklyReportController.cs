using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PCA.Data;

namespace PCA.Controllers
{
    [Authorize(Roles = "Supervisor")]
    public class WeeklyReportController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WeeklyReportController(ApplicationDbContext context)
        {
            _context = context;
        }

    }
}
