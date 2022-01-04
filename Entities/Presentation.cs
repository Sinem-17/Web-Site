using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairService.DAL.Entities
{
    [Table("Presentation")]
    public class Presentation
    {
        public int ID { get; set; }

        [StringLength(100), Column(TypeName = "varchar(100)"), Display(Name = "Slide Başlığı")]
        public string Title { get; set; }

        [StringLength(150), Column(TypeName = "varchar(150)"), Display(Name = "Slide Açıklaması")]
        public string Description { get; set; }

        [StringLength(150), Column(TypeName = "varchar(150)"), Display(Name = "Resim Dosyası")]
        public string Picture { get; set; }

        [StringLength(150), Column(TypeName = "varchar(150)"), Display(Name = "Ürün Adresi")]
        public string Link { get; set; }

        [Display(Name = "Görüntülenme Sırası")]
        public int DisplayIndex { get; set; }
    }
}
