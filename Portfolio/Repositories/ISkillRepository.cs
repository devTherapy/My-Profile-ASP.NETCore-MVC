using System.Collections.Generic;
using Portfolio.Models;

namespace Portfolio.Repositories
{
    /// <summary>
    /// returns a list of my technical skills and their grade by percentage
    /// </summary>
    public interface ISkillRepository
    {
        List<Skill> GetAllSkills();
    }
}