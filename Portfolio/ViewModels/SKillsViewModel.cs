using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Models;

namespace Portfolio.ViewModels
{
    public class SKillsViewModel
    {
        public string SkillDescriptor { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
