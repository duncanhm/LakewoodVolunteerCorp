using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LakewoodVolunteerCorp.Models
{
    public class Duty
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DutyID { get; set; }
        public string Title { get; set; }
        public int Hours { get; set; }

        public virtual ICollection<SignUp> SignUps { get; set; }
    }
}