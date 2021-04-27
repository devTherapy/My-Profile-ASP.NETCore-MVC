namespace Portfolio.Models
{
    public class Profession
    {   
        public int ProfessionId { get; set; }
        public string ProfessionName { get; set; }

        public Profession(int id, string professionName)
        {
            ProfessionId = id;
            ProfessionName = professionName;
        }

    }
}