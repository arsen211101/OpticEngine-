using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpticEngine.ViewModels
{
    public class HolidaysViewModel
    {
        [Key]
        public int Id { get; set; }

     
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Title")]
        [DataType(DataType.Text)]
        public string Title { get; set; }

  
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Holiday Date")]
        [DataType(DataType.Date)]
        public DateTime HolidayDate { get; set; }

    }
}
