using DataAccessLayer.Models;

namespace BusinessLayer.Services.SortService
{
    public interface ISortService
    {
        Task<List<Sort>> GetAllSorts();
        Task<Sort>? GetSingleSort(int Id);
        Task<List<Sort>> AddSort(Sort sort);
        Task<List<Sort>?> UpdateSort(int Id, Sort request);
        Task<List<Sort>?> DeleteSort(int Id);
    }
}
