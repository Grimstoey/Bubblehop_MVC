using Bubblehop.DataAccess.DataRepository.RepositoryInterface;



namespace Bubblehop.DataAccess.DataRepository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _dbContext;

        public ITravelPlanData TravelPlan { get; private set; }

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            TravelPlan = new TravelPlanData(_dbContext);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
