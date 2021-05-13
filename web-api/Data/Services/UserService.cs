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

        public List<Users> GetAllUsers() => _context.Users.ToList();

        public Users GetUserById(int userId) => _context.Users.FirstOrDefault(n => n.id == userId);

        public Users UpdateUserById(int userId, UserVM user)
        {
            var _user = _context.Users.FirstOrDefault(n => n.id == userId);
            if (_user != null)
            {
                _user.FirstName = user.FirstName;
                _user.LastName = user.LastName;
                _user.Email = user.Email;
                _user.Country = user.Country;
                _user.JobTitle = user.JobTitle;

                _context.SaveChanges();
            }
            return _user;
        }

        public void DeleteUserById(int userId)
        {
            var _user = _context.Users.FirstOrDefault(n => n.id == userId);
            if (_user != null)
            {
                _context.Remove(_user);
                _context.SaveChanges();
            }
        }
    }
}
