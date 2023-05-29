﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterWellTest.Domain.Entities
{
    public class UserLogin : IdentityUserLogin<int>
    {
        public virtual User? User { get; set; }
    }
}
