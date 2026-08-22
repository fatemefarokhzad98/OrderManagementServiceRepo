using Microsoft.AspNetCore.Identity;
using OrderManagementService.Application.Contracts.Authentication;
using OrderManagementService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Infrastructure.Services
{
    public class PasswordService:IPasswordService
    {
        private static readonly object UserContext = new();

        private readonly PasswordHasher<object> _passwordHasher = new();

        public string Hash(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Password is required.", nameof(password));
            }

            return _passwordHasher.HashPassword(UserContext, password);
        }

        public bool Verify(string passwordHash, string password)
        {
            if (string.IsNullOrWhiteSpace(passwordHash) || string.IsNullOrEmpty(password))
                return false;

            var result = _passwordHasher.VerifyHashedPassword(UserContext, passwordHash, password);

            return result is PasswordVerificationResult.Success or PasswordVerificationResult.SuccessRehashNeeded;


        }
    }
}
