using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fitnessApp.Models.Models.LogModels;

namespace fitnessApp.Services.IServices
{
    public interface ILogService
    {
        Task<bool> CreateLog(LogCreate model);
        Task<List<LogListItem>> GetLogs();
        Task<LogDetail> GetLog(int id);
        Task<LogUpdate> UpdateLog(LogUpdate model);
        Task<bool> DeleteLog(int id); 
    }
}