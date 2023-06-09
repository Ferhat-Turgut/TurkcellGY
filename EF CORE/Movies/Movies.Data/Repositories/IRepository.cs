﻿using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Data.Repositories
{
    public interface IRepository<T> where T: class,IEntity,new()
    {
        
        Task CreateAsync(T entity);
        //void Create(T entity);  Hem senkron hem asenkron olarak aynı anda tanımlanabilir.
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task<IList<T>> GetAllAsync();
        Task<T?> GetByIdAsync(int id);
    }
}
