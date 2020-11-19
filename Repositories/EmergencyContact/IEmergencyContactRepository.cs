using OpticEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticEngine.Repositories
{
    public interface IEmergencyContactRepository
    {
        Task<List<EmergencyContact>> GetContact(int profileId);
        Task<EmergencyContact> Create(EmergencyContact contact);
        void Delete(EmergencyContact contact);

    }
}
