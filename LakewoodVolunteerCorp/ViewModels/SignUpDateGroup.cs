using System;
using System.ComponentModel.DataAnnotations;

namespace LakewoodVolunteerCorp.ViewModels
{
    public class SignUpDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? SignUpDate { get; set; }

        public int VolunteerCount { get; set; }
    }
}