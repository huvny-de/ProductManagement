using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Entities
{
    public class Product
    {
        [Key]
        [Required]
        [MaxLength(6)]
        [DisplayName("Mã Sản Phẩm")]
        public int ProductId { get; set; }


        [DisplayName("Tên Sản Phẩm")]
        public String Name { get; set; }

        [DisplayName("Giá")]
        public Double Price { get; set; }
        [DisplayName("Số lượng")]

        public Double Amount { get; set; }

        [Required]
        [ForeignKey("Cateid")]
        [DisplayName("Mã Danh Mục")]

        //public Category Categories { get; set; }
        public int CategoryId { get; set; }
        public Category Cateid { get; set; }

    }
}
