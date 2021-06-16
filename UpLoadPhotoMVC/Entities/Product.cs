using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UpLoadPhotoMVC.Entities
{
    public class Product
    {
        [Key]
        [Required]
        [DisplayName("Mã Sản Phẩm")]
        public int ProductId { get; set; }


        [DisplayName("Tên Sản Phẩm")]
        public String Name { get; set; }

        [DisplayName("Giá")]
        public String Price { get; set; }
        

        [DisplayName("Hình Ảnh")]
        public String Photo { get; set; }

    }
}
