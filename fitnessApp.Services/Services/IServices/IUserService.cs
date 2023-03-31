using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fitnessApp.Models.UserModels;

namespace fitnessApp.Services.IServices
{
    public interface IUserService
    {
        Task<bool> CreateUser(UserCreate model);
        Task<List<UserListItem>> GetUsers();
        Task<UserDetail> GetUser(int id);
        Task<UserUpdate> UpdateUser(UserUpdate model);
        Task<bool> DeleteUser(int id);
    }
}