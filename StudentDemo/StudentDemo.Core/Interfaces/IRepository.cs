using StudentDemo.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemo.Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        // Tüm kayıtları getir
        Task<IEnumerable<T>> GetAllAsync();
       
        // Id ye göre kayıt getir
        Task<T?> GetByIdAsync(int id);
        
        // Koşlua göre filtrele
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
        
        // Yeni kayıt getir
        Task<T> AddAsync(T entity);

        // Kaıt güncelle
        void Update(T entity);

        // Kayıt sil
        void Delete(T entity);

        //Kayıt var mı kontrol et
        Task<bool> ExistsAsync(int id);
    }
}
