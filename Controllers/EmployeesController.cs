using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OpticEngine.Models;
using OpticEngine.Services;
using OpticEngine.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpticEngine.Controllers
{
    [Authorize]
    public class EmployeesController : Controller
    {
        private readonly IProfileService _profileService;
        private readonly IMapper _mapper;
        private readonly IHolidaysService _holidaysService;

        public EmployeesController(IProfileService profileService, IMapper mapper,IHolidaysService holidaysService)
        {
            _profileService = profileService;
            _mapper = mapper;
            _holidaysService = holidaysService;
        }

        public async Task<IActionResult> AllEmployees()
        {
            var profile = await _profileService.GetProfiles();
            return View(_mapper.Map<List<ProfileViewModel>>(profile));
        }
        [HttpGet]
        public async Task<IActionResult> Holidays()
        {
            List<Holidays> holidays = await _holidaysService.GetHoliday();
            return View(_mapper.Map<List<HolidaysViewModel>>(holidays));
        }
        
        public IActionResult LeavesAdmin()
        {
            return View(); //bug
        }

        public IActionResult LeavesEmployees()
        {
            return View();
        }

        public IActionResult LeaveSettings()
        {
            return View();
        }

        public IActionResult AttendanceAdmin()
        {
            return View();
        }

        public IActionResult AttendanceEmployee()
        {
            return View();
        }

        public IActionResult Departments()
        {
            return View();
        }

        public IActionResult Designations()
        {
            return View();
        }

        public IActionResult Timesheet()
        {
            return View();
        }

        public IActionResult Overtime()
        {
            return View();
        }
    }
}