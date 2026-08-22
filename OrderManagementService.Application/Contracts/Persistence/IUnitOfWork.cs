using OrderManagementService.Application.Common.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Application.Contracts.Persistence
{
    public interface IUnitOfWork
    {
        Task<OperationResult<int>> CommitAsync(CancellationToken cancellationToken = default);

    }
}
