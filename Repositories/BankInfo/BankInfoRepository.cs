using Microsoft.EntityFrameworkCore;
using OpticEngine.Data;
using OpticEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticEngine.Repositories.Bank
{
    public class BankInfoRepository : IBankInfoRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public BankInfoRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<BankInfo> Create(BankInfo bankInfo)
        {
            if (bankInfo.Id == 0)
                _applicationDbContext.BankInfo.Add(bankInfo);
            else
                _applicationDbContext.BankInfo.Update(bankInfo);
            await _applicationDbContext.SaveChangesAsync();
            return bankInfo;
        }

        public void Delete(BankInfo info)
        {
            _applicationDbContext.BankInfo.Remove(info);
            _applicationDbContext.SaveChanges();
        }

        public async Task<BankInfo> GetBankInfos(int profileId)
        {
            var query =  from bank in _applicationDbContext.BankInfo
                        where bank.ProfileId == profileId
                         select bank;
            return await query.FirstOrDefaultAsync<BankInfo>();
        }
    }
}
