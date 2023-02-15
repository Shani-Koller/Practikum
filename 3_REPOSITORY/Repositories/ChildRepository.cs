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
    public class ChildRepository : IChildRepository
    {
        private readonly IDataSource _source;

        public ChildRepository(IDataSource _source)
        {
            this._source = _source;
        }

        public async  Task<Child> AddAsync(Child child)
        {
            _source.children.Add(child);
            await _source.SaveChangesAsync();
            return child;
        }

        public async Task DeleteAsync(int id)
        {
            Child child =  await GetByIdAsync(id);
            await _source.SaveChangesAsync();
            _source.children.Remove(child); 
        }

        public async Task<List<Child>> GetAllAsync()
        {
           return await _source.children.ToListAsync(); 
        }

        public async Task<Child> GetByIdAsync(int id)
        {
            return await _source.children.FindAsync(id);
        }

        public async Task<Child> UpdateAsync(Child child)
        {
            var upDateChild = _source.children.Update(child);
            await _source.SaveChangesAsync();   
            return upDateChild.Entity;
        }
    }


}
