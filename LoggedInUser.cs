using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel_booking
{
    public class LoggedInUser
    {
        public int UserId { get; set; }
        public string Username { get; set; } // The user's email
        public string FullName { get; set; }

        public string UserEmail { get; set; }
    }
}
