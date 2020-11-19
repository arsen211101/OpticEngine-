using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OpticEngine.Models
{
    public class Profile
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("FirstName")]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("LastName")]
        public string LastName { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("MiddleName")]
        public string MiddleName { get; set; }


        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Team")]
        [DataType(DataType.Text)]
        public string Team { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Position")]
        [DataType(DataType.Text)]
        public string Position { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("DateOfJoin")]
        [DataType(DataType.Text)]
        public string DateOfJoin { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Phone")]
        public string Phone { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Column(TypeName = "Date")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Birthday")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Address")]


        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Gender")]
        [DataType(DataType.Text)]
        public string Gender { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Passport No.")]
        [DataType(DataType.Text)]
        public string PassportNo { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Passport Exp Date.")]
        [DataType(DataType.Text)]
        public string ExPassportDate { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Tel.")]
        [DataType(DataType.Text)]
        public string Telephone { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Nationality")]
        [DataType(DataType.Text)]
        public string Nationality { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Religion")]
        [DataType(DataType.Text)]
        public string Religion { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Marital Status")]
        [DataType(DataType.Text)]
        public string MaritalStatus { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Employment Of Spouse")]
        [DataType(DataType.Text)]
        public string EmploymentOfSpouse { get; set; }

        [Column(TypeName = "int")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Employment Of Spouse")]
        [DataType(DataType.Text)]
        public int CountChildrens { get; set; }

    }
}
