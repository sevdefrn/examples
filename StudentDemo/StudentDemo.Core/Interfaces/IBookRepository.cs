using StudentDemo.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemo.Core.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        // Kitaba göre metotlar
        Task<IEnumerable<Book>> GetBooksByAuthorsIdAsync(int authorId);
        Task<Book?> GetBookWithAuthorAsync(int id);
        Task<IEnumerable<Book>> GetAllWithAuthorsAsync();
        Task<Book?> GetByIsbnAsync(string isbn);
    }
}
