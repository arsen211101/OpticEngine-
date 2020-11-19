using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OpticEngine.Models
{
    public class EmergencyContact
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Relationship")]
        public string Relationship { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Phone")]
        public string Phone { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Mobile")]
        public string Mobile { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [Required(ErrorMessage = "This field is required.")]
        public string Type { get; set; }

        [Column(TypeName = "int")]
        [DisplayName("ProfileId")]
        [ForeignKey("Profile")]
        public int ProfileId { get; set; }

        public Profile Profile { get; set; }

    }
}
