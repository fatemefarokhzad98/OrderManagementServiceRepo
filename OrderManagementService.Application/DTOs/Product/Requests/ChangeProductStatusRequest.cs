using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Application.DTOs.Product.Requests
{
   public class ChangeProductStatusRequest
    {
        public bool IsActive { get; init; }
    }
}
