using OpticEngine.Models;
using OpticEngine.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticEngine.Services
{
    public class EmergencyContactService : IEmergencyContactService
    {
        private readonly IEmergencyContactRepository _contactRepository;
        public EmergencyContactService(IEmergencyContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<EmergencyContact> Create(EmergencyContact contact)
        {
            return await _contactRepository.Create(contact);
        }

        public void Delete(EmergencyContact contact)
        {
            _contactRepository.Delete(contact);
        }

        public async Task<List<EmergencyContact>> GetContact(int profileId)
        {
            return await _contactRepository.GetContact(profileId);
        }
    }
}
