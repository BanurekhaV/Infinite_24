﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTesting
{
    public class User
    {
        public Boolean IsAdmin { get; set; }
    }

    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanbeCancelledBy(User user)
        {
            if (user.IsAdmin)
                return true;
            if (MadeBy == user)
                return true;
            return false;
        }
    }
}
