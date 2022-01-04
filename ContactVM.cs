using RepairService.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepairService.WebUI.ViewModels
{
    public class ContactVM
    {
        public ContactForm ContactForm { get; set; }
        public SiteInformation Social { get; set; }
        public SiteInformation Contact { get; set; }
    }
}
