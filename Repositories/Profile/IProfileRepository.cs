using OpticEngine.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpticEngine.Repositories
{
   public interface IProfileRepository
    {
        Task<Profile> GetProfile(int profileId);
        Task<List<Profile>> GetProfiles();
        Task<Profile> Create(Profile profile);
        void Delete(Profile profile);
    }
}
