﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFinal.Models
{
    //Afik-Login
    //public enum UserType
    //{
    //    Admin,
    //    Customer
    //}
    public class Members
    {

        public string MemberName { get; set; }
        public int MembersID { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        //public string Type { get; set; }
        //public string Password { get; set; } //Osher-Login
        public StudioClass studioClass { get; set; }
        ////Join
        //public ICollection<StudioClass> FavoriteLessons { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
    }
}
