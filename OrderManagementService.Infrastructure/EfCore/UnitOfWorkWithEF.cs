using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OrderManagementService.Application.Common.Results;
using OrderManagementService.Application.Contracts.Persistence;
namespace OrderManagementService.Infrastructure.EfCore
{
    public class UnitOfWorkWithEF(ILogger<UnitOfWorkWithEF> logger, MainDbContext db) : IUnitOfWork
    {
        public async Task<OperationResult<int>> CommitAsync(CancellationToken cancellationToken)
        {
            try
            {
                int rowAffected = await db.SaveChangesAsync(cancellationToken);
                return rowAffected > 0 ? OperationResult<int>.Success(rowAffected)
                    : OperationResult<int>.Failure(new("DataBase.NoChange", "تغییری در دیتابیس ایجاد نشد"));
            }
            catch (DbUpdateConcurrencyException ex)
            {
                logger.LogError("Concurrency issue occurred. Exception={@Exception}", ex);
                return OperationResult<int>.Failure(new Error("Database.Concurrency", "داده‌ها توسط کاربر دیگری تغییر کرده‌اند."));
            }
            catch (DbUpdateException ex)
            {
                logger.LogError("Database update failed. Exception={@Exception}", ex);
                return OperationResult<int>.Failure(new Error("Database.Update", "خطا در ذخیره‌سازی اطلاعات در پایگاه داده."));
            }
            catch (Exception ex)
            {
                logger.LogCritical(ex, "Unknown database error. Exception={@Exception}", ex);
                return OperationResult<int>.Failure(new Error("Database.Unknown", "یک خطای سیستمی رخ داده است."));
            }
        }
    }
}
