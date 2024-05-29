using BubblehopWeb.DataAccess.DataRepository.RepositoryInterface;
using BubblehopWeb.DataAccess.ManageDataMethod;
using BubblehopWeb.Models;

namespace BubblehopWeb.DataAccess.DataRepository
{
    public class TravelPlanData : ManageData<TravelPlan>, ITravelPlanData
    {
        private ApplicationDbContext _dbContext;

        public TravelPlanData(ApplicationDbContext dbContext) : base(dbContext)
        //เป็นคลาสที่รับพารามิเตอร์ แล้วส่งไปที่คลาสแม่ ManageData เพราะคลาสแม่เปิด ctor รับพารามิเตอร์เพื่อเอาไปทำ DbSet<T>
        {
            _dbContext = dbContext;
        }
    }
}
