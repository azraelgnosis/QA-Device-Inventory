using System;
using System.Collections.Generic;

namespace qadi.Models
{
    public class UserViewModel
    {
        public List<User> users { get; set; }
        public User user { get; set; }
        public List<int> userIDs { get; set; }
    }
}
