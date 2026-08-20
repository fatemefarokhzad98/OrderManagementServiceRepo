using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Domain.Enums
{
    public enum OrderStatus
    {
        Pending=1,
        Confirmed,
        Shipped,
        Delivered,
    }
}
