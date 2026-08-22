using OrderManagementService.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Domain.Entities
{
   public class Customer :BaseEntity<long>, IAuditableEntity
    {
        private Customer()
        {
                
        }
      public Customer(string firstName,string lastName,string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        #region Properties
        public string FirstName { get; private  set; } = null!;
        public string LastName { get; private set; } = null!;
        public string PhoneNumber { get; private set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        #endregion


        #region Navigation Properties
        public ICollection<Order> Orders { get; set; } = [];


        #endregion
        public void Update(string firstName, string lastName, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }
    }
}
