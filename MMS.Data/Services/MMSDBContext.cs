using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using MMS.Data.Models;

namespace MMS.Data.Services
{
    public class MMSDBContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
    } 
}
 