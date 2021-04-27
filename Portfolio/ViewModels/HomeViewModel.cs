using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Models;

namespace Portfolio.ViewModels
{
    public class HomeViewModel
    {
        public string Name { get; set; }
        public List<Profession> Professions { get; set; }
    }
}
