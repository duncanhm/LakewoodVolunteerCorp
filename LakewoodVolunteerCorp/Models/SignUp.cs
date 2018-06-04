using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LakewoodVolunteerCorp.Models
{
    public enum Performance
    {
        Excellent, Satisfactory, Subpar, Poor
    }

    public class SignUp
    {
        public int SignUpID { get; set; }
        public int DutyID { get; set; }
        public int VolunteerID { get; set; }
        public Performance? Performance { get; set; }

        public virtual Duty Duty { get; set; }
        public virtual Volunteer Volunteer { get; set; }
    }
}