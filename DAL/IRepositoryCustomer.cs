using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class IRepositoryCustomer : IRepository<Customer>
    {
        public void Create(Customer _object)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer _object)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer _object)
        {
            throw new NotImplementedException();
        }
    }
}
