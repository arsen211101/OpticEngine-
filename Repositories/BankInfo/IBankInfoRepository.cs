using OpticEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticEngine.Repositories.Bank
{
   public interface IBankInfoRepository
    {

        Task<BankInfo> GetBankInfos(int profileId);
        Task<BankInfo> Create(BankInfo info);
        void Delete(BankInfo info);
    }
}
