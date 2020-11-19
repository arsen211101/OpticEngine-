using Microsoft.EntityFrameworkCore;
using OpticEngine.Data;
using OpticEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticEngine.Repositories
{
    public class EmergencyContactRepostiory : IEmergencyContactRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public EmergencyContactRepostiory(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<EmergencyContact> Create(EmergencyContact contact)
        {
            if (contact.Id == 0)
                _applicationDbContext.Contacts.Add(contact);
            else
                _applicationDbContext.Contacts.Update(contact);
            await _applicationDbContext.SaveChangesAsync();
            return contact;
        }

        public void Delete(EmergencyContact contact)
        {
            _applicationDbContext.Contacts.Remove(contact);
            _applicationDbContext.SaveChanges();
        }

        public async Task<List<EmergencyContact>> GetContact(int profileId)
        {
            return await _applicationDbContext.Contacts.Where(x => x.ProfileId == profileId).ToListAsync();
        }
    }
}
