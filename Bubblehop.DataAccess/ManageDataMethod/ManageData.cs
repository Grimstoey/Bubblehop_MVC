using BubblehopWeb.DataAccess.ManageDataMethod.Interface;
using Microsoft.EntityFrameworkCore;

namespace Bubblehop.DataAccess.ManageDataMethod
{
    public class ManageData<T> : IManageData<T> where T : class
    {
        private readonly ApplicationDbContext _dbContext;
        internal DbSet<T> dbSet;

        public ManageData(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            dbSet = _dbContext.Set<T>();
        }

        public async Task AddWithAsync(T entity)
        {
            await dbSet.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllWithAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<T> GetByIdWithAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task RemoveWithAsync(T entity)
        {
            dbSet.Remove(entity);
            /*
                Marks the entity for deletion
                ทำเครื่องหมายเอนทิตีเป็นลบแล้วภายในเครื่องมือติดตามการเปลี่ยนแปลงของ 
                Entity Framework ซึ่งหมายความว่าเอนทิตีถูกตั้งค่าสถานะเพื่อการลบ 
                แต่ยังไม่มีการดำเนินการฐานข้อมูลเกิดขึ้น เอนทิตียังคงอยู่ในฐานข้อมูลในขั้นตอนนี้
            */

            await _dbContext.SaveChangesAsync();
            /*
                Sends the delete command to the database
                วิธีการนี้ดำเนินการกับฐานข้อมูลจริง ๆ โดยจะส่งคำสั่ง DELETE ไปยังฐานข้อมูลสำหรับเอนทิตีทั้งหมดที่ทำเครื่องหมายว่าถูกลบแล้ว
                การเรียกเมธอดนี้เป็นแบบอะซิงโครนัสและเกี่ยวข้องกับการโต้ตอบจริงกับฐานข้อมูล เมื่อวิธีนี้เสร็จสิ้น เอนทิตีจะถูกลบออกจากฐานข้อมูล
            */
        }
    }
}
