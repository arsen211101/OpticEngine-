using OpticEngine.Data;
using OpticEngine.Models;
using OpticEngine.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticEngine.Services
{
    public class HolidaysService : IHolidaysService
    {
        private readonly IHolidaysRepository _holidays;
        public HolidaysService(IHolidaysRepository holidays)
        {
            _holidays = holidays;
        }
        public async Task<Holidays> Create(Holidays model)
        {
            return await _holidays.Create(model);
        }

        public void Delete(Holidays model)
        {
            _holidays.Delete(model);
        }

        public async Task<Holidays> GetHoliday(int profileId)
        {
            return await _holidays.GetHoliday(profileId);
        }

        public async Task<List<Holidays>> GetHoliday()
        {
            return await _holidays.GetHoliday();
        }
    }
}
