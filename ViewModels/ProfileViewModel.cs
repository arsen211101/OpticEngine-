using OpticEngine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpticEngine.ViewModels
{
    public class ProfileViewModel
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("FirstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("LastName")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("MiddleName")]
        public string MiddleName { get; set; }


        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Team")]
        [DataType(DataType.Text)]
        public string Team { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Position")]
        [DataType(DataType.Text)]
        public string Position { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("DateOfJoin")]
        [DataType(DataType.Text)]
        public string DateOfJoin { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Phone")]
        public string Phone { get; set; }


        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Birthday")]
        [DataType(DataType.DateTime)]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Address")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }


        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Gender")]
        [DataType(DataType.Text)]
        public string Gender { get; set; }


        
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Passport No.")]
        [DataType(DataType.Text)]
        public string PassportNo { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Passport Exp Date.")]
        [DataType(DataType.Text)]
        public string ExPassportDate { get; set; }

        
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Tel.")]
        [DataType(DataType.Text)]
        public string Telephone { get; set; }

       
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Nationality")]
        [DataType(DataType.Text)]
        public string Nationality { get; set; }

       
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Religion")]
        [DataType(DataType.Text)]
        public string Religion { get; set; }

        
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Marital Status")]
        [DataType(DataType.Text)]
        public string MaritalStatus { get; set; }

        
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Employment Of Spouse")]
        [DataType(DataType.Text)]
        public string EmploymentOfSpouse { get; set; }

        
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Employment Of Spouse")]
        [DataType(DataType.Text)]
        public int CountChildrens { get; set; }

        public List<EmergencyContactViewModel> contactViewModel { get; set; }

        public BankInfoViewModel bankInfo { get; set; }
    }
}
