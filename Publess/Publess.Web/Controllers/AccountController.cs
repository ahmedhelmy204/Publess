using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Publess.Web.Models.Account;
using Publess.Service.Users;
using Publess.Core.Domain.Users;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Publess.Web.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        #region Register

        // GET: /Account/Register/
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register/
        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            User user = new User
            {
                Username = model.Username,
                Email = model.Email,
                Password = model.Password,
                InsertedOn = DateTime.Now
            };

            _userService.InsertUser(user);

            return RedirectToAction("Index", "Home");
        }

        #endregion Register
    }
}
