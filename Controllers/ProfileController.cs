using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OpticEngine.Data;
using OpticEngine.Services;
using OpticEngine.Services.BankInfo;
using OpticEngine.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpticEngine.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly IProfileService _profileService;
        private readonly IEmergencyContactService _emergencyContactService;
        private readonly IBankInfoService _bankInfoService;
        private readonly IMapper _mapper;

        public ProfileController(IProfileService profileService, IEmergencyContactService emergencyService, IBankInfoService bankInfoService, IMapper mapper)
        {
            _profileService = profileService;
            _emergencyContactService = emergencyService;
            _bankInfoService = bankInfoService;
            _mapper = mapper;
        }

        public async Task<IActionResult> EmployeeProfile(int empId)
        {
            Models.Profile profile = await _profileService.GetProfile(empId);
            ProfileViewModel a = _mapper.Map<ProfileViewModel>(profile);
            a.contactViewModel = _mapper.Map<List<EmergencyContactViewModel>>(await _emergencyContactService.GetContact(a.EmployeeId));
            a.bankInfo = _mapper.Map<BankInfoViewModel>(await _bankInfoService.GetBankInfos(a.EmployeeId));
            return View(a);
        }

        public IActionResult ClientProfile()
        {
            return View();
        }
    }
}