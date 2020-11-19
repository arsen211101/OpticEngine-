using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OpticEngine.Models
{
    public class BankInfo
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("BankName")]
        [DataType(DataType.Text)]
        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Account")]
        [DataType(DataType.Text)]
        public string Account { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("SwiftCode")]
        [DataType(DataType.Text)]
        public string SwiftCode { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("BankAddress")]
        [DataType(DataType.Text)]
        public string BankAddress { get; set; }

        [Column(TypeName = "int")]
        [DisplayName("ProfileId")]
        [ForeignKey("Profile")]
        public int ProfileId { get; set; }

        public Profile Profile { get; set; }

    }
}
