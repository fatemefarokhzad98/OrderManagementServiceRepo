using OrderManagementService.Application.Common.Results;
using OrderManagementService.Application.DTOs.Authentication.Requests;
using OrderManagementService.Application.DTOs.Authentication.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrderManagementService.Application.Contracts.Services
{
    public interface IAuthService
    {
        Task<OperationResult<TokenResponse>> LoginAsync(LoginRequest request, CancellationToken cancellationToken = default);

        

        Task<OperationResult<TokenResponse>> RefreshAsync(RefreshTokenRequest request, CancellationToken cancellationToken = default);



        Task<OperationResult> LogoutAsync(RefreshTokenRequest request, CancellationToken cancellationToken = default);


    }
}
