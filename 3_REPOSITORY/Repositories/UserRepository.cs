using _3_REPOSITORY.Entities;
using _3_REPOSITORY.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_REPOSITORY.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDataSource _source;

        public UserRepository(IDataSource source)
        {
            _source = source;
        }

        public async Task<User> AddAsync(User user)
        {
            var addUser= _source.users.Add(user);
            await _source.SaveChangesAsync();
            return addUser.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            _source.users.Remove(await GetByIdAsync(id));
            await _source.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _source.users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _source.users.FindAsync(id);
        }

        public async Task<User> UpdateAsync(User user)
        {
          var updateUser= _source.users.Update(user);
            await _source.SaveChangesAsync();
            return updateUser.Entity;
        }
    }
}
