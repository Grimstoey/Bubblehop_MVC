namespace BubblehopWeb.DataAccess.ManageDataMethod.Interface
{
    public interface IManageData<T> where T : class
    {
        Task<IEnumerable<T>> GetAllWithAsync();
        Task<T> GetByIdWithAsync(int id);
        Task AddWithAsync(T entity);
        Task RemoveWithAsync(T entity);
    }
}
