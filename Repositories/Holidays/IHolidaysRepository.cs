using OpticEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticEngine.Repositories
{
    public interface IHolidaysRepository
    {
        Task<Holidays> GetHoliday(int profileId);
        Task<List<Holidays>> GetHoliday();
        Task<Holidays> Create(Holidays holidaysModel);
        void Delete(Holidays holidaysModel);
    }
}
