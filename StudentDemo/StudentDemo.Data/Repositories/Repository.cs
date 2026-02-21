using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using StudentDemo.Core.Interfaces;
using StudentDemo.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemo.Data.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _dbSet;

        protected Repository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        /// <summary>
        /// Tüm kayıtları getirir
        /// </summary>
        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        /// <summary>
        /// ID'ye göre tek kayıt getirir
        /// </summary>
        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        /// <summary>
        /// Koşula göre filtreler (Lambda Expression kullanarak)
        /// Örnek: FindAsync(b => b.Price > 50)
        /// </summary>
        public virtual async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }

        /// <summary>
        /// Yeni kayıt ekler
        /// NOT: SaveChanges çağrılana kadar veritabanına yazılmaz
        /// </summary>
        public virtual async Task<T> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }

        ///<summary>
        ///Yeni kayıt ekler
        /// NOT: SaveChanges çağrılana kadar veritabanına yazılmaz
        ///</summary>
        public virtual void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Kayıt siler 
        /// NOT: SaveChanges çağrılana kadar veritabanından silinmez
        /// </summary>
        public virtual void Delete(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }

        /// <summary>
        /// Id'ye göre kayıt var mı kontorl eder
        /// </summary>
        public virtual async Task<bool> ExistsAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            return entity != null;
        }
    }
}