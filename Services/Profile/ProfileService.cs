using OpticEngine.Models;
using OpticEngine.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticEngine.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IProfileRepository _profileRepository;
        public ProfileService(IProfileRepository profileRepository)
        {
            _profileRepository = profileRepository;
        }
        public async Task<Profile> Create(Profile profile)
        {
            return await _profileRepository.Create(profile);
        }

        public void Delete(Profile profile)
        {
            _profileRepository.Delete(profile);
        }

        public async Task<Profile> GetProfile(int profileId)
        {
            return await _profileRepository.GetProfile(profileId);
        }

        public async Task<List<Profile>> GetProfiles()
        {
            return await _profileRepository.GetProfiles();
        }
    }
}
