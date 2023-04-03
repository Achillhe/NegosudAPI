using BusinessLayer.Services.SortService;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using NegosudAPI.Data;

namespace BusinessLayer.Services.TypeService
{
    public class SortService : ISortService
    {
        private readonly DataContext _context;

        public SortService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Sort>> AddSort(Sort sort)
        {
            _context.Sorts.Add(sort);
            await _context.SaveChangesAsync();
            return await _context.Sorts.ToListAsync();
        }

        public async Task<List<Sort>?> DeleteSort(int Id)
        {
            var sort = await _context.Sorts.FindAsync(Id); ;
            if (sort is null)
                return null;

            _context.Sorts.Remove(sort);
            await _context.SaveChangesAsync();
            return await _context.Sorts.ToListAsync();
        }

        public async Task<List<Sort>> GetAllSorts()
        {
            var sorts = await _context.Sorts.ToListAsync();
            return sorts;
        }

        public async Task<Sort?> GetSingleSort(int Id)
        {
            var sort = await _context.Sorts.FindAsync(Id);
            if (sort is null)
                return null;

            return sort;
        }

        public async Task<List<Sort>?> UpdateSort(int Id, Sort request)
        {
            var sort = await _context.Sorts.FindAsync(Id);
            if (sort is null)
                return null;

            sort.Name = request.Name;


            await _context.SaveChangesAsync();

            return await _context.Sorts.ToListAsync();
        }
    }
}
