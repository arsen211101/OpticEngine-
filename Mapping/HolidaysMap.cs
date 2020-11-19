
using OpticEngine.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticEngine.Mapping
{
    public class HolidaysMap:AutoMapper.Profile
    {
        public HolidaysMap()
        {
            CreateMap<OpticEngine.Models.Holidays, HolidaysViewModel>();
            CreateMap<HolidaysViewModel, OpticEngine.Models.Holidays>();
        }
    }
}
