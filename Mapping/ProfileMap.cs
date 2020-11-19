using AutoMapper;
using OpticEngine.Models;
using OpticEngine.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OpticEngine.Mapping
{
    public class ProfileMap : AutoMapper.Profile
    {
        public ProfileMap()
        {
            CreateMap<OpticEngine.Models.Profile, ProfileViewModel>();
            CreateMap<ProfileViewModel,OpticEngine.Models.Profile>();
        }
    }
}
