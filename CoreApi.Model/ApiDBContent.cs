using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApi.Model
{
    public class ApiDBContent : DbContext
    {
        public ApiDBContent(DbContextOptions<ApiDBContent> options)
                : base(options)
        {
        }

        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<ClassInfo> ClassInfo { get; set; }
    }
}
