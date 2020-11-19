using OpticEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticEngine.Services
{
    public interface IHolidaysService
    {
        Task<Holidays> GetHoliday(int profileId);
        Task<List<Holidays>> GetHoliday();
        Task<Holidays> Create(Holidays model);
        void Delete(Holidays model);
    }
}
