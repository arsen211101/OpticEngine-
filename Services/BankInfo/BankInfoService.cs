using OpticEngine.Repositories.Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpticEngine.Models;

namespace OpticEngine.Services.BankInfo
{
    public class BankInfoService:IBankInfoService
    {
        private readonly IBankInfoRepository _bankInfoRepository;
        public BankInfoService(IBankInfoRepository bankInfoRepository)
        {
            _bankInfoRepository = bankInfoRepository;
        }

        public async Task<OpticEngine.Models.BankInfo> Create(OpticEngine.Models.BankInfo info)
        {
            return await _bankInfoRepository.Create(info);
        }

        public void Delete(OpticEngine.Models.BankInfo bankInfo)
        {
            _bankInfoRepository.Delete(bankInfo);
        }

        public async Task<OpticEngine.Models.BankInfo> GetBankInfos(int profileId)
        {
            return await _bankInfoRepository.GetBankInfos(profileId);
        }
    }
}
