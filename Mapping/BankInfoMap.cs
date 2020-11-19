using OpticEngine.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticEngine.Mapping
{
    public class BankInfoMap:AutoMapper.Profile
    {
        public BankInfoMap()
        {
            CreateMap<OpticEngine.Models.BankInfo, BankInfoViewModel>();
            CreateMap<BankInfoViewModel, OpticEngine.Models.BankInfo>();
        }
    }
}
