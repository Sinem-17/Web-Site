using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairService.DAL.Entities
{
    [Table("SiteInformation")]
    public class SiteInformation
    {
        public int ID { get; set; }

        [StringLength(150), Column(TypeName = "varchar(150)"), Display(Name = "Bilgi 1")]
        public string Info1 { get; set; }

        [StringLength(150), Column(TypeName = "varchar(150)"), Display(Name = "Bilgi 2")]
        public string Info2 { get; set; }

        [StringLength(150), Column(TypeName = "varchar(150)"), Display(Name = "Bilgi 3")]
        public string Info3 { get; set; }

        [StringLength(150), Column(TypeName = "varchar(150)"), Display(Name = "Bilgi 4")]
        public string Info4 { get; set; }

        [Column(TypeName = "text"), Display(Name = "Bilgi 5")]
        public string Info5 { get; set; }

        [Column(TypeName = "text"), Display(Name = "Bilgi 6")]
        public string Info6 { get; set; }

        public ESiteInfo ESiteInfo { get; set; }
    }
}
