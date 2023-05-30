using Assignment_Chsarp5_datntph19899._1_DataProcessing._1_Models;
using Assignment_Chsarp5_datntph19899._1_DataProcessing._3_Context;
using Assignment_Chsarp5_datntph19899._2_Handle_Operation._1_IServices;
using Microsoft.EntityFrameworkCore;

namespace Assignment_Chsarp5_datntph19899._2_Handle_Operation._2_Services
{
    public class UserServices : IUserServices
    {
        private readonly Assignment_Context _dbContext;

        public UserServices(Assignment_Context dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Users>> GetUsersAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<Users> GetUserByIdAsync(Guid id)
        {
            return await _dbContext.Users.FindAsync(id);
        }

        public async Task<Guid> AddUserAsync(Users user)
        {
            user.ID = Guid.NewGuid();
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            return user.ID;
        }

        public async Task<bool> UpdateUserAsync(Users user)
        {
            _dbContext.Entry(user).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteUserAsync(Guid id)
        {
            var user = await _dbContext.Users.FindAsync(id);
            if (user == null)
                return false;

            _dbContext.Users.Remove(user);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
