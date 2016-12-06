using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ZenithDataLib;

namespace zenithsociety.DataContext
{
    public class EventContext : DbContext
    {
        public EventContext() : base("DefaultConnection") { }

        public DbSet<Event> Events { get; set; }
        public DbSet<Activity> Activities { get; set; }


    }
}