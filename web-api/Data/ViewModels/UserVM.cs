using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_api.Data.ViewModels
{
    public class UserVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string JobTitle { get; set; }
    }
}
