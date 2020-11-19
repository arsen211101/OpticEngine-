using Microsoft.EntityFrameworkCore;
using OpticEngine.Data;
using OpticEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticEngine.Repositories
{
    public class HolidaysRepository : IHolidaysRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public HolidaysRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<Holidays> Create(Holidays model)
        {
            if (model.Id == 0)
            {
              _applicationDbContext.Holidays.Add(model);
            }
            else
            {
                _applicationDbContext.Holidays.Update(model);
            }
            await _applicationDbContext.SaveChangesAsync();
            return model;
        }

        public void Delete(Holidays holidaysModel)
        {
            _applicationDbContext.Remove(holidaysModel);
            _applicationDbContext.SaveChanges();
        }

        public async Task<Holidays> GetHoliday(int profileId)
        {
           
           return await _applicationDbContext.Holidays.FindAsync(profileId);
        }

        public async Task<List<Holidays>> GetHoliday()
        {
            return await _applicationDbContext.Holidays.ToListAsync();
        }
    }
}
