using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fitnessApp.Models.LogBookModels;
using fitnessApp.Services.IServices;

namespace fitnessApp.Services.Services
{
    public class LogBookService : ILogBookService
    {
        public Task<bool> CreateLogBook(LogBookCreate model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteLogBook(int id)
        {
            throw new NotImplementedException();
        }

        public Task<LogBookDetail> GetLogBook(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<LogBookListItem>> GetLogBooks()
        {
            throw new NotImplementedException();
        }

        public Task<LogBookUpdate> UpdateLogBook(LogBookUpdate model)
        {
            throw new NotImplementedException();
        }
    }
}