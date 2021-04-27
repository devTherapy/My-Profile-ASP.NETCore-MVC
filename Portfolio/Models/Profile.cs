using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class Profile
    {


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AboutMeDescription { get; set; }
        public string SkillDescription { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Profession> Professions { get; set; }
        public List<Contact> Contact { get; set; }

        public Profile(string firstName, string lastName, string aboutMeDescription, string skillDescription, List<Skill> skills, List<Profession> professions, List<Contact> contact)
        {
            FirstName = firstName;
            LastName = lastName;
            AboutMeDescription = aboutMeDescription;
            SkillDescription = skillDescription;
            Skills = skills;
            Professions = professions;
            Contact = contact;
        }


    }
}
