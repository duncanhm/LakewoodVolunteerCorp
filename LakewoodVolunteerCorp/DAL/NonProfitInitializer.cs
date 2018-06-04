using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LakewoodVolunteerCorp.Models;

namespace LakewoodVolunteerCorp.DAL
{
    public class NonProfitInitializer : DropCreateDatabaseIfModelChanges<NonProfitContext>
    {
        protected override void Seed(NonProfitContext context)
        {
            var volunteers = new List<Volunteer>
            {
            new Volunteer{FirstName="Jeff",LastName="Katz",SignUpDate=DateTime.Parse("2018-05-15")},
            new Volunteer{FirstName="Marlene",LastName="Greene",SignUpDate=DateTime.Parse("2018-05-11")},
            new Volunteer{FirstName="Axel",LastName="White",SignUpDate=DateTime.Parse("2018-05-11")},
            new Volunteer{FirstName="Gary",LastName="Jackson",SignUpDate=DateTime.Parse("2018-05-11")},
            new Volunteer{FirstName="Sue",LastName="Franks",SignUpDate=DateTime.Parse("2018-05-17")},
            new Volunteer{FirstName="Mark",LastName="Long",SignUpDate=DateTime.Parse("2018-05-09")},
            new Volunteer{FirstName="April",LastName="Maynard",SignUpDate=DateTime.Parse("2018-05-15")}
            };

            volunteers.ForEach(s => context.Volunteers.Add(s));
            context.SaveChanges();
            var duties = new List<Duty>
            {
            new Duty{DutyID=11,Title="Garbage Pickup",Hours=2,},
            new Duty{DutyID=12,Title="Park Beautification",Hours=4,},
            new Duty{DutyID=13,Title="Soup Kitchen",Hours=8,},
            new Duty{DutyID=14,Title="Donation Collection",Hours=4,}
            };
            duties.ForEach(s => context.Duties.Add(s));
            context.SaveChanges();
            var signUps = new List<SignUp>
            {
            new SignUp{VolunteerID=1,DutyID=14,Performance=Performance.Satisfactory},
            new SignUp{VolunteerID=1,DutyID=12,Performance=Performance.Subpar},
            new SignUp{VolunteerID=1,DutyID=13,Performance=Performance.Excellent},
            new SignUp{VolunteerID=2,DutyID=12,Performance=Performance.Excellent},
            new SignUp{VolunteerID=2,DutyID=14,Performance=Performance.Excellent},
            new SignUp{VolunteerID=3,DutyID=11},
            new SignUp{VolunteerID=3,DutyID=14},
            new SignUp{VolunteerID=4,DutyID=12,Performance=Performance.Excellent},
            new SignUp{VolunteerID=5,DutyID=11,Performance=Performance.Satisfactory},
            new SignUp{VolunteerID=6,DutyID=13,Performance=Performance.Poor},
            new SignUp{VolunteerID=7,DutyID=12,Performance=Performance.Satisfactory},
            new SignUp{VolunteerID=7,DutyID=14},
            };
            signUps.ForEach(s => context.SignUps.Add(s));
            context.SaveChanges();
        }
    }
}