using fitnessApp.Models.LogBookModels;

namespace fitnessApp.Services.IServices
{
    public interface ILogBookService
    {
        Task<bool> CreateLogBook(LogBookCreate model);
        Task<List<LogBookListItem>> GetLogBooks();
        Task<LogBookDetail> GetLogBook(int id);
        Task<LogBookUpdate> UpdateLogBook(LogBookUpdate model);
        Task<bool> DeleteLogBook(int id);
    }
}