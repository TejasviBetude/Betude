using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace L_M_S_codefirst.ContextEmployee
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Designation { get; set; }

        public int NoOfDays { get; set; }
        public DateTime SatrtDate { get; set; }
        public DateTime EndDate { get; set; }
        public string TypeOfLeave { get; set; }
        public string Reason { get; set; }
    }
}
