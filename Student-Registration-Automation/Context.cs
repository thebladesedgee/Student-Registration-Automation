using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration_Automation
{
    internal class Context : DbContext
    {
        public DbSet<StudentInformation> studentdata { get; set; }
    }
}
