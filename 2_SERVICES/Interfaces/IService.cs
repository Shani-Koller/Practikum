﻿using _3_REPOSITORY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_SERVICES.Interfaces
{
    public interface IService<T>
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task<T> UpdateAsync(T t);
        Task<T> AddAsync(T t);
    }
}
