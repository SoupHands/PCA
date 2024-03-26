using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PCA.Models;

namespace PCA.Controllers
{
    [Authorize(Roles = "Supervisor")]
    public class UserManagementController : Controller
    {
        private readonly UserManager<User> _userManager;

        public UserManagementController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

    }

}
