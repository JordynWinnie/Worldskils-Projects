﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TPQR_Session1_01082022_BlazorWeb
{
    public partial class UserType
    {
        public UserType()
        {
            Users = new HashSet<User>();
        }

        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
