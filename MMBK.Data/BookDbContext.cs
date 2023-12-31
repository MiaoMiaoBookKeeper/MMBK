﻿using MMBK.Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMBK.Data
{
    public class BookDbContext:DbContext
    {
        public BookDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
