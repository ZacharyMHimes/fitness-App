using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fitnessApp.Data;
using fitnessApp.Data.DBContext;
using fitnessApp.Data.Entities;
using fitnessApp.Models.UserModels;
using fitnessApp.Services.IServices;

namespace fitnessApp.Services.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;
        public UserService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateUser(UserCreate model)
        {
            var user = new User()
            {   Username = model.Username,
                Password = model.Password };
            
            await _context.Users.AddAsync(user);
            return await _context.SaveChangesAsync() > 0; 
        }

        public async Task<bool> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if(user is null) return false;
            _context.Users.Remove(user);
            return await _context.SaveChangesAsync() > 0;
        }

        public Task<UserDetail> GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserListItem>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task<UserUpdate> UpdateUser(UserUpdate model)
        {
            throw new NotImplementedException();
        }
    }
}