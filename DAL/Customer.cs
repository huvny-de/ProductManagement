using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL
{
    [Table("Customers", Schema = "dbo")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "FullName")]

        public string FullName { get; set; }
        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "Salary")]
        public int Salary { get; set; }
    }
}
