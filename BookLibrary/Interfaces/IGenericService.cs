namespace Library.BLL.Interfaces
{
    public interface IGenericService<TEntity, TModel>
        where TEntity : class
        where TModel : class
    {
        Task<IEnumerable<TModel>> GetAllAsync();
        Task<TModel?> GetByIdAsync(int id);
        Task<TModel> AddAsync(TModel model);
        Task<TModel> UpdateAsync(int id, TModel model);
        Task<bool> DeleteAsync(int id);
    }
}