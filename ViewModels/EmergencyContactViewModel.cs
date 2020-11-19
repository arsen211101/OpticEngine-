using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpticEngine.ViewModels
{
    public class EmergencyContactViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Relationship")]
        public string Relationship { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Mobile")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Type { get; set; }
    }
}
