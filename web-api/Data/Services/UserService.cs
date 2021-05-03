using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_api.Data.Models;
using web_api.Data.ViewModels;

namespace web_api.Data.Services
{
    public class UserService
    {
        private AppDbContext _context;
        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public void AddUser(UserVM user)
        {
            var _user = new Users()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Country = user.Country,
                JobTitle = user.JobTitle
            };
            _context.Users.Add(_user);
            _context.SaveChanges();
        }
    }
}
