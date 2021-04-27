using Hgtech.Control.Infrastructure.Models;
using System.Collections.Generic;

namespace Hgtech.Control.Infrastructure.Constants
{
    public static class Global
    {
        private static List<User> _allUsers;
        public static List<User> AllUsers
        {
            get { return _allUsers; }
            set { _allUsers = value; }
        }
    }
}
