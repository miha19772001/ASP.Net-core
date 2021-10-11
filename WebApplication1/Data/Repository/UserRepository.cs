using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Interfaces;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Repository
{
    public class UserRepository : IUsers
    {
        private readonly AppDBContext _appDBContext;

        public UserRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public IEnumerable<User> AllUsers => _appDBContext.Users.Include(u => u.Login);
    }
}
