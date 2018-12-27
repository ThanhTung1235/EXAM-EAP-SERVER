using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EXAM_EAP.Models
{
    public class EXAM_EAPContext : DbContext
    {
        public EXAM_EAPContext (DbContextOptions<EXAM_EAPContext> options)
            : base(options)
        {
        }

        public DbSet<EXAM_EAP.Models.Employee> Employee { get; set; }
    }
}
