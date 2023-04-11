using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fitnessApp.Models.Models.LogModels;
using fitnessApp.Services.IServices;

namespace fitnessApp.Services.Services
{
    public class LogService : ILogService
    {
        public Task<bool> CreateLog(LogCreate model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteLog(int id)
        {
            throw new NotImplementedException();
        }

        public Task<LogDetail> GetLog(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<LogListItem>> GetLogs()
        {
            throw new NotImplementedException();
        }

        public Task<LogUpdate> UpdateLog(LogUpdate model)
        {
            throw new NotImplementedException();
        }
    }
}