using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FrisbeeGolfCourseMap.Models;

namespace FrisbeeGolfCourseMap.Data
{
    public class FrisbeeGolfCourseMapContext : DbContext
    {
        public FrisbeeGolfCourseMapContext (DbContextOptions<FrisbeeGolfCourseMapContext> options)
            : base(options)
        {
        }

        public DbSet<FrisbeeGolfCourseMap.Models.Course> Course { get; set; }
    }
}
