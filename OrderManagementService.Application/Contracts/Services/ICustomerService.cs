using OrderManagementService.Application.Common.Results;
using OrderManagementService.Application.DTOs.Customer.Requests;
using OrderManagementService.Application.DTOs.Customer.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Application.Contracts.Services
{
    public interface ICustomerService
    {

        Task<OperationResult<long>> CreateAsync(CreateCustomerRequest request, CancellationToken cancellationToken = default);

        Task<OperationResult<CustomerResponse>> GetByIdAsync(long customerId, CancellationToken cancellationToken = default);
        Task<OperationResult<IReadOnlyCollection<CustomerResponse>>> GetAllAsync(CancellationToken cancellationToken = default);

        Task<OperationResult> UpdateAsync(long customerId, UpdateCustomerRequest request, CancellationToken cancellationToken = default);



    }
}
