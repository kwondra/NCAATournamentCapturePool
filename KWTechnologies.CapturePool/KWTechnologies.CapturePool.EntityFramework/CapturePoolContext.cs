using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using KWTechnologies.CapturePool.Core.Models;
using KWTechnologies.CapturePool.EntityFramework.Configurations;

namespace KWTechnologies.CapturePool.EntityFramework
{
    public class CapturePoolContext : DbContext, IDisposable
    {
        public IDbSet<Conference> Conferences { get; set; }
        public IDbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ConferenceConfiguration());
        }
    }
}
