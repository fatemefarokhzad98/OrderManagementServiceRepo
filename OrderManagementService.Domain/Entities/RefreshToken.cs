using OrderManagementService.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Domain.Entities
{
    public class RefreshToken : BaseEntity<long>
    {
        private RefreshToken()
        {
        }
        public RefreshToken(string tokenHash, DateTime expiresAt, long userId)
        {
            TokenHash = tokenHash;
            ExpiresAt = expiresAt;
            UserId = userId;
        }
        public string TokenHash { get; private set; } = null!;

        public DateTime ExpiresAt { get; private set; }

        public DateTime? RevokedAt { get; private set; }

        public long UserId { get; private set; }

        #region Navigation Properties

        public User User { get; private set; } = null!;

        #endregion

        public bool IsExpired =>
            DateTime.UtcNow >= ExpiresAt;

        public bool IsRevoked =>
            RevokedAt.HasValue;

        public bool IsActive =>
            !IsExpired && !IsRevoked;

        public void Revoke()
        {
            if (IsRevoked)
                return;

            RevokedAt = DateTime.UtcNow;
        }
    }
    }
