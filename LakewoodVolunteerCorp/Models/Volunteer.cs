using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace LakewoodVolunteerCorp.Models
{
    public class Volunteer
    {
        public int ID { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Sign Up Date")]
        public DateTime SignUpDate { get; set; }

        public virtual ICollection<SignUp> SignUps { get; set; }
    }
}