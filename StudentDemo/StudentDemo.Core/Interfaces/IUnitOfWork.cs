using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemo.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        // Repository'leri tanımla
        IBookRepository Books { get; }
        IAuthorRepository Authors { get; }

        // tüm değişleri kaydet
        Task<int> SaveChangesAsync();

        // Transaction başlat
        Task BeginTransactionAsync();

        // Transaction onayla
        Task CommitTransactionAsync();

        // Transaction geri al
        Task RollbackTransactionAsync();
    }
}
