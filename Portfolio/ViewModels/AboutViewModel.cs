using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using Portfolio.Models;

namespace Portfolio.ViewModels
{
    public class AboutViewModel
    { 
        public List<Contact> Contacts { get; set; }
        public string AboutDescriptor { get; set; }
    }
}
