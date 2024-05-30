using Bubblehop.DataAccess.DataRepository.RepositoryInterface;
using Bubblehop.DataAccess.ManageDataMethod;
using Bubblehop.Models;
using BubblehopWeb.DataAccess;
using BubblehopWeb.DataAccess.ManageDataMethod;



namespace Bubblehop.DataAccess.DataRepository
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
