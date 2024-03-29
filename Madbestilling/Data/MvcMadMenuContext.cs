﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMadMenu.Models;

namespace MvcMadMenu.Data
{
    public class MvcMadMenuContext : DbContext
    {
        public MvcMadMenuContext(DbContextOptions<MvcMadMenuContext> options) : base(options)
        {
        }

        public DbSet<MadMenu> Madmenu { get; set; }
    }
}
