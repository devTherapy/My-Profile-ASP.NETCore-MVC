using System.Collections.Generic;
using Portfolio.Models;

namespace Portfolio.Repositories
{/// <summary>
/// returns a list of my current professions
/// </summary>
    public interface IProfessionRepository
    {
        List<Profession> GetAllProfessions();
    }
}