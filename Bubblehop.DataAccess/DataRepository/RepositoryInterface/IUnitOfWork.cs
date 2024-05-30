namespace Bubblehop.DataAccess.DataRepository.RepositoryInterface
{
    public interface IUnitOfWork
    {
        ITravelPlanData TravelPlan { get; }

        void Save();
    }
}
