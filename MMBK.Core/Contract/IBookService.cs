using MMBK.Core.Model;
using MMBK.Core.Pagination;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MMBK.Core.Contract
{
    public interface IBookService
    {
        Task<PagedResult<Book>> GetPagedAsync(BookCriteria criteria);
        Task<Book> GetOneAsync(int id);
        Task<Book> CreateAsync(Book entry);
        Task<int> UpdateAsync(int id, Book entry);
        Task<int> DeleteAsync(int id);
    }
}
