using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OpticEngine.Models;

namespace OpticEngine.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Holidays> Holidays { get; set; }
        public virtual DbSet<EmergencyContact> Contacts { get; set; }

        public virtual DbSet<BankInfo> BankInfo { get; set; }
    }
}
