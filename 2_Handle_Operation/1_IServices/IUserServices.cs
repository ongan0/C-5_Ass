using Assignment_Chsarp5_datntph19899._1_DataProcessing._1_Models;

namespace Assignment_Chsarp5_datntph19899._2_Handle_Operation._1_IServices
{
    public interface IUserServices
    {
        Task<List<Users>> GetUsersAsync();
        Task<Users> GetUserByIdAsync(Guid id);
        Task<Guid> AddUserAsync(Users user);
        Task<bool> UpdateUserAsync(Users user);
        Task<bool> DeleteUserAsync(Guid id);
    }
}
