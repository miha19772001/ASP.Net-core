using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Interfaces;

namespace WebApplication1.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsers _users;

        public UsersController(IUsers users)
        {
            _users = users;
        }


        // [Route("User/Authentication")]
        //[Route("User/Dashboard")]

        [Route("User/Registration")]
        public ViewResult Registration()
        {
            return View();
        }
    }
}
