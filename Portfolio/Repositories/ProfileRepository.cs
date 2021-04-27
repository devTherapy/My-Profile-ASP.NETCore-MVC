using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Models;

namespace Portfolio.Repositories
{
    
   
    public class ProfileRepository : IProfileRepository
    {

        IProfessionRepository professonRepository = new ProfessionRepository();
        ISkillRepository skillRepository = new SkillRepository();
        IContactRepository contactRepository= new ContactRepository();
        public Profile GetProfile()
        {
            var ListOfProfessions = professonRepository.GetAllProfessions();
            var ListOfContacts = contactRepository.GetAllContacts();
            var ListOfSkills = skillRepository.GetAllSkills();
            var aboutDescription =
                "I am a resourceful individual with a very high work ethic committed to making valuable contributions in problem solving and achievement of team goals. I am a ife long learner with strong decision making skills. I also demonstrate excellent interpersonal, phone and digital communication skills.";
            var skillDescription =
                "I am primarily a backend developer, I have worked extensively with .NET and Node to build REST APIs, however, I have also done a good number of jobs on the front end with technologies such as react, angular, javascript and css. I am very confident in my ability to deliver with these technologies and can also pick up new technologies pretty fast";
            var profile = new Profile("Folusayo", "Abe", aboutDescription, skillDescription, ListOfSkills, ListOfProfessions, ListOfContacts);
            return profile;
        }


    }
}
