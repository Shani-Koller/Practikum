using _3_REPOSITORY.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_REPOSITORY.Interfaces
{
    public interface IDataSource
    {
        //Task<int> SaveChanges();
      public  DbSet<User> users { get; set; }
       public DbSet<Child> children { get; set; }

        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
