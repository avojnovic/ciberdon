﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using BussinesObjects;

namespace ControlObjects
{
    public class CiberdonDbContext : DbContext
    {

         public DbSet<User> User { get; set; }
       


    }
}
