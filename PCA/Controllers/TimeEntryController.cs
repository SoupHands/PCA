using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PCA.Data;

namespace PCA.Controllers
{
    [Authorize(Roles = "Intern")]
    public class TimeEntryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TimeEntryController(ApplicationDbContext context)
        {
            _context = context;
        }

    }
}
