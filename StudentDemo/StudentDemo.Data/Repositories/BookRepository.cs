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
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(AppDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Yazaraa göre kitapları getirir
        /// </summary>
        public async Task<IEnumerable<Book>> GetBooksByAuthorIdAsync(int authorId)
        {
            return await _dbSet
                .Where(b => b.AuthorId == authorId)
                .Include(b => b.Author) // İlişkili yazarı da getirir
                .ToListAsync();
        }

        /// <summary>
        /// Kitabı yazarı ile birlikte getirir (Eager Loading)
        /// </summary>
    public async Task<Book?>  GetBookWithAuthorAsync(int id)
        {
            return await _dbSet
                .Include(b => b.Author)
                .FirstOrDefaultAsync(b => b.Id == id);
        }

        /// <summary>
        /// Tüm kitapları yazarıyla birlikte getirir
        /// </summary>
        public async Task<IEnumerable<Book>> GetAllWithAuthorsAsync()
        {
            return await _dbSet
                .Include(b => b.Author)
                .ToListAsync();
        }

        /// <summary>
        /// ISBN'e göre kitap getirir
        /// </summary>
    public async Task<Book?> GetByIsbnAsync(string isbn)
        {
            return await _dbSet
                .Include(b => b.Author)
                .FirstOrDefaultAsync();
        }
    }
}
