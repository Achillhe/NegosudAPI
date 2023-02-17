using NegosudAPI.Services.TypeService;

namespace NegosudAPI.Services.TypeService
{
    public class TypeService : ITypeService
    {
        private readonly DataContext _context;

        public TypeService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Models.Type>> AddType(Models.Type type)
        {
            _context.Types.Add(type);
            await _context.SaveChangesAsync();
            return await _context.Types.ToListAsync();
        }

        public async Task<List<Models.Type>?> DeleteType(int Id)
        {
            var type = await _context.Types.FindAsync(Id); ;
            if (type is null)
                return null;

            _context.Types.Remove(type);
            await _context.SaveChangesAsync();
            return await _context.Types.ToListAsync();
        }

        public async Task<List<Models.Type>> GetAllTypes()
        {
            var types = await _context.Types.ToListAsync();
            return types;
        }

        public async Task<Models.Type?> GetSingleType(int Id)
        {
            var type = await _context.Types.FindAsync(Id);
            if (type is null)
                return null;

            return type;
        }

        public async Task<List<Models.Type>?> UpdateType(int Id, Models.Type request)
        {
            var type = await _context.Types.FindAsync(Id);
            if (type is null)
                return null;

            type.Name = request.Name;
            

            await _context.SaveChangesAsync();

            return await _context.Types.ToListAsync();
        }
    }
}
