using System.Threading.Tasks;
using BetterRead.Shared.Domain.Book;

namespace BetterRead.Shared.Services.Abstractions
{
    public interface IBookService
    {
        Task<Book> GetBookByIdAsync(int bookId);
        Task<Book> GetBookByUrlAsync(string url);
    }
}