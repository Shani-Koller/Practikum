using _3_REPOSITORY.Entities;
using _3_REPOSITORY.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_REPOSITORY
{
    public class DataSource:DbContext, IDataSource
    {

        public Microsoft.EntityFrameworkCore. DbSet<User> users { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Child> children { get; set; }

      
        public DataSource(  )
        {

        }
        public DataSource(DbContextOptions <DataSource> options ):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=sqlsrv;Initial Catalog=#ShaniKollerProgect;Integrated Security=True; TrustServerCertificate=True");
        }

        

    }
}
