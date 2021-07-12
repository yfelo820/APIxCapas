﻿using APIxCapas.DB;
using APIxCapas.Interface;
using APIxCapas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace APIxCapas.Repository
{
    public class CommerceRepository<T> : ICommerceRepository<T> where T : Base
    {
        private readonly CommerceContext _db;

        public CommerceRepository(CommerceContext dbContext) => _db = dbContext;

        public async Task<T> Add(T entity)
        {
            await _db.Set<T>().AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> Add(List<T> entities)
        {
            await _db.Set<T>().AddRangeAsync(entities);
            await _db.SaveChangesAsync();
            return entities;
        }

        public async Task Delete(T entity)
        {
            _db.Set<T>().Remove(entity);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(List<T> entities)
        {
            _db.Set<T>().RemoveRange(entities);
            await _db.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
        }

        public async Task Update(List<T> entities)
        {
            foreach (T entity in entities) _db.Entry(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
        }

        public async Task<List<T>> Find(Expression<Func<T, bool>> predicate, string[] includes = null)
        {
            // return the result of the query using the specification's criteria expression
            return await Query(includes)
                            .Where(predicate)
                            .ToListAsync();
        }

        public async Task<List<T>> GetAll()
        {
            return await _db.Set<T>().ToListAsync();
        }

        public async Task<T> Get(int id)
        {
            return await _db.Set<T>().FindAsync(id);
        }

        public IQueryable<T> Query(string[] includes = null)
        {
            includes = includes ?? new string[0];
            return includes.Aggregate(
                _db.Set<T>().AsQueryable(),
                (current, include) => current.Include(include)
            );
        }

        public async Task<T> FindSingle(Expression<Func<T, bool>> predicate, string[] includes = null)
        {
            // return the result of the query using the specification's criteria expression
            return await Query(includes)
                            .Where(predicate)
                            .FirstOrDefaultAsync();
        }

        public async Task<bool> Any(Expression<Func<T, bool>> predicate)
        {
            return await _db.Set<T>().AnyAsync(predicate);
        }

        public DbSet<T> EntityDbSet() => _db.Set<T>();


    }
}
