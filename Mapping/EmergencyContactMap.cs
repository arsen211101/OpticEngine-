using OpticEngine.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticEngine.Mapping
{
    public class EmergencyContactMap : AutoMapper.Profile
    {
        public EmergencyContactMap()
        {
            CreateMap<OpticEngine.Models.EmergencyContact, EmergencyContactViewModel>();
            CreateMap<EmergencyContactViewModel, OpticEngine.Models.EmergencyContact>();

        }
    }
}
