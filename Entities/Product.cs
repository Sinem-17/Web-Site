using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairService.DAL.Entities
{
    [Table("Product")]
    public class Product
    {
        public int ID { get; set; }

        [StringLength(100), Column(TypeName = "varchar(100)"), Display(Name = "Ürün Adı")]
        public string Name { get; set; }

        [StringLength(250), Column(TypeName = "varchar(250)"), Display(Name = "Ürün Açıklaması")]
        public string Description { get; set; }

        [Column(TypeName = "text"), Display(Name = "Ürün Detayı")]
        public string Detail { get; set; }

        [Display(Name = "Kayıt Tarihi")]
        public DateTime RecDate { get; set; }

        [Display(Name = "Kategorisi")]
        public int? CategoryID { get; set; }
        public Category Category { get; set; }

        public ICollection<Picture> Pictures { get; set; }

    }
}
