using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairService.DAL.Entities
{
    [Table("Category")]
    public class Category
    {
        public int ID { get; set; }

        [StringLength(50), Column(TypeName = "varchar(50)"), Display(Name = "Kategori Adı")]
        public string Name { get; set; }

        [Display(Name = "Görüntüleme Sırası")]
        public int DisplayIndex { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
