using Microsoft.EntityFrameworkCore;
using OpticEngine.Data;
using OpticEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticEngine.Repositories
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ProfileRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<Profile> Create(Profile profile)
        {
            if (profile.EmployeeId == 0)
                _applicationDbContext.Profiles.Add(profile);
            else
                _applicationDbContext.Profiles.Update(profile);
            await _applicationDbContext.SaveChangesAsync();
            return profile;
        }

        public void Delete(Profile profile)
        {
            _applicationDbContext.Profiles.Remove(profile);
            _applicationDbContext.SaveChanges();
        }

        public async Task<Profile> GetProfile(int profileId)
        {
            return await _applicationDbContext.Profiles.FindAsync(profileId);
        }

        public async Task<List<Profile>> GetProfiles()
        {
            return await _applicationDbContext.Profiles.ToListAsync();
        }
    }
}
