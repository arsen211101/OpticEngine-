using OpticEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticEngine.Services
{
    public interface IProfileService
    {
        Task<Profile> GetProfile(int profileId);
        Task<List<Profile>> GetProfiles();
        Task<Profile> Create(Profile profile);
        void Delete(Profile profile);

    }
}
