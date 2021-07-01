using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataServiceAPI.Entities
{
    public class Customer
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
        public double Salary { get; set; }

    }
}
