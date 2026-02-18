using StudentDemo.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemo.Core.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {
        // Yazara göre metotlar
        Task<Author?> GetAuthorWithBooksAsync(int id);
        Task<IEnumerable<Author>> GetAllWithBooksAsync();
        Task<IEnumerable<Author>> GetAuthorsByCountryAsync(string country);
        
    }
}
