using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OpticEngine.Models
{
    public class Holidays
    {

        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Title")]
        [DataType(DataType.Text)]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Holiday Date")]
        [DataType(DataType.Date)]
        public DateTime HolidayDate { get; set; }


    }

}
