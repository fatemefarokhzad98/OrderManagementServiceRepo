using OrderManagementService.Application.Common.Results;

namespace OrderManagementService.Api.ErrorHandling
{
    public static class ErrorStatusCodeMapper
    {
        public static int Map(Error error)
        {
            var code = error.Code;
            if (code.StartsWith("Auth.InvalidCredentials", StringComparison.OrdinalIgnoreCase) || code.StartsWith("Auth.InvalidRefreshToken", StringComparison.OrdinalIgnoreCase))

                return StatusCodes.Status401Unauthorized;

            if (code.EndsWith(".NotFound", StringComparison.OrdinalIgnoreCase))

                return StatusCodes.Status404NotFound;

            if (code.Contains(".Duplicate", StringComparison.OrdinalIgnoreCase))

                return StatusCodes.Status409Conflict;

            if (code.Contains("Insufficient", StringComparison.OrdinalIgnoreCase) || code.Contains("InvalidTransition", StringComparison.OrdinalIgnoreCase) || code.Contains("Inactive", StringComparison.OrdinalIgnoreCase))

                return StatusCodes.Status409Conflict;

            if (code.StartsWith("Database.", StringComparison.OrdinalIgnoreCase) || code.StartsWith("DataBase.", StringComparison.OrdinalIgnoreCase))

                return StatusCodes.Status500InternalServerError;
            if (error.Code.Equals("Auth.InvalidCredentials", StringComparison.OrdinalIgnoreCase) || error.Code.Equals("Auth.InvalidRefreshToken", StringComparison.OrdinalIgnoreCase))

                return StatusCodes.Status401Unauthorized;

            if (error.Code.Equals("Auth.UserInactive", StringComparison.OrdinalIgnoreCase))

                return StatusCodes.Status403Forbidden;
            

            return StatusCodes.Status400BadRequest;
        }

    }
}
