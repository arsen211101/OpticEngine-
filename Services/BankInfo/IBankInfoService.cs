using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OpticEngine.Data;
using OpticEngine.Models;

namespace OpticEngine.Services.BankInfo
{
    public interface IBankInfoService
    {
        Task<OpticEngine.Models.BankInfo> GetBankInfos(int profileId);
        Task<OpticEngine.Models.BankInfo> Create(OpticEngine.Models.BankInfo info);
        void Delete(OpticEngine.Models.BankInfo info);
    }
}
