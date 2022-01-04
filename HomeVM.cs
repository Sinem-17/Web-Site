using RepairService.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepairService.WebUI.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> RecentProducts { get; set; }
        public IEnumerable<Presentation> Presentations { get; set; }
        public SiteInformation Meta { get; set; }
    }
}
