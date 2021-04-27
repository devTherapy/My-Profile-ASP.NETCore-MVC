using Portfolio.Models;

namespace Portfolio.Repositories
{ /// <summary>
    /// returns a profile of me consisting of my biodata, professinns, technical skills, and contacts
    /// </summary>
    public interface IProfileRepository
    {
        Profile GetProfile();
    }
}