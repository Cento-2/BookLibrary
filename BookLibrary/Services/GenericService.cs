using AutoMapper;
using Library.BLL.Interfaces;
using Library.DAL.Interfaces;

namespace Library.BLL.Services
{
    public class GenericService<TEntity, TModel> : IGenericService<TEntity, TModel>
        where TEntity : class
        where TModel : class
    {
        private readonly IGenericRepository<TEntity> _repository;
        private readonly IMapper _mapper;

        public GenericService(IGenericRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TModel>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<TModel>>(entities);
        }

        public async Task<TModel?> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return _mapper.Map<TModel>(entity);
        }

        public async Task<TModel> AddAsync(TModel model)
        {
            var entity = _mapper.Map<TEntity>(model);
            var created = await _repository.AddAsync(entity);
            return _mapper.Map<TModel>(created);
        }

        public async Task<TModel> UpdateAsync(int id, TModel model)
        {
            var entity = _mapper.Map<TEntity>(model);
            var updated = await _repository.UpdateAsync(entity);
            return _mapper.Map<TModel>(updated);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}