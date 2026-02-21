using Microsoft.EntityFrameworkCore;
using StudentDemo.Core.Interfaces;
using StudentDemo.Data.Context;
using StudentDemo.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemo.Data.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(AppDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Yazarı kitaplarıyla birlikte getirir (Eager Loading)
        /// </summary>
    public async Task<Author?> GetAuthorWithBooksAsync(int id)
        {
            return await _dbSet
                .Include(a => a.Books) // İlişkili kitapları da getirir
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        /// <summary>
        /// Tüm yazarları kitaplarıyla birlikte getirir
        /// </summary>
        public async Task<IEnumerable<Author>> GetAllWithBooksAsync()
        {
            return await _dbSet
                .Include(a => a.Books)
                .ToListAsync();
        }

        /// <summary>
        /// Ülkeye göre yazarları getirir
        /// </summary>
        public async Task<IEnumerable<Author>> GetAuthorsByCountryAsync(string country)
        {
            return await _dbSet
                .Where(a => a.Country == country)
                .Include(a => a.Books)
                .ToListAsync();
        }
    }
}
