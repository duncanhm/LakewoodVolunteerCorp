using System;
using System.Collections.Generic;

namespace LakewoodVolunteerCorp.Models
{
    public class Volunteer
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime SignUpDate { get; set; }

        public virtual ICollection<SignUp> SignUps { get; set; }
    }
}