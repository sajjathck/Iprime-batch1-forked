﻿using Microsoft.EntityFrameworkCore;
using SMSAPI.Entities;
namespace SMSAPI
{
    public class MyContext:DbContext
    {
        private IConfiguration configuration;

        public MyContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Tutor> Tutor { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("SMSConn"));
        }
    }
}
