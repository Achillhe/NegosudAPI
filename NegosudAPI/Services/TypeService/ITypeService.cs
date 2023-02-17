namespace NegosudAPI.Services.TypeService
{
    public interface ITypeService
    {
        Task<List<Models.Type>> GetAllTypes();
        Task<Models.Type>? GetSingleType(int Id);
        Task<List<Models.Type>> AddType(Models.Type type);
        Task<List<Models.Type>?> UpdateType(int Id, Models.Type request);
        Task<List<Models.Type>?> DeleteType(int Id);
    }
}
