using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel_booking
{
    public static class UserSession
    {
        public static LoggedInUser CurrentUser { get; private set; }

        public static void StartSession(LoggedInUser user)
        {
            CurrentUser = user;
        }

        public static void EndSession()
        {
            CurrentUser = null;
        }
    }
}
