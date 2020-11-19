using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpticEngine.ViewModels
{
    public class BankInfoViewModel
    {
        [Key]
        public int Id { get; set; }
        public string BankName { get; set; }

        public string Account { get; set; }

        public string SwiftCode { get; set; }

        public string BankAddress { get; set; }
    }
}
