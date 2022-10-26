﻿using Microsoft.EntityFrameworkCore;
using MyCRM.Domain.Entities.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCRM.Data.Context
{
    public class CrmContext : DbContext
    {
        public CrmContext(DbContextOptions<CrmContext> options) : base(options)
        {

        }

        #region DbSet
        public DbSet<User> Users { get; set; }
        public DbSet<Marketer> Marketers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        #endregion
    }
}
