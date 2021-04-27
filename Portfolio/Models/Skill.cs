namespace Portfolio.Models
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public string Percentage { get; set; }
        public Skill(int id, string skillName, string percentage)
        {
            SkillId = id;
            SkillName = skillName;
            Percentage = percentage;
        }
        
    }
}