using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Entities
{
    public class Category
    {
        //[Key]
        // [Required]
        [DisplayName("Mã Danh Mục")]
        public int CategoryId { get; set; }


        [DisplayName("Tên Danh Mục")]
        public String Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
