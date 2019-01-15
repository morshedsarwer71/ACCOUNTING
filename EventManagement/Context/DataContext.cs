using EventManagement.Areas.Accounting.Models;
using EventManagement.Areas.Global.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EventManagement.Context
{
    public class DataContext:DbContext
    {
        public DataContext() : base("EventDBContext") { }
        //Accounting Data Context
        public DbSet<AccountsHead> AccountsHeads { get; set; }
        public DbSet<ReportHead> ReportHeads { get; set; }
        public DbSet<Journal> Journals { get; set; }


        //Global Data Context
        public DbSet<Concern> Concerns { get; set; }
        public DbSet<SystemUser> SystemUsers { get; set; }

    }
}