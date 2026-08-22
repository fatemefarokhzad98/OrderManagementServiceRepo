using Microsoft.AspNetCore.Mvc;
using OrderManagementService.Api.ErrorHandling;
using OrderManagementService.Application.Common.Results;

namespace OrderManagementService.Api.Controllers
{
    [ApiController]
    public abstract class ApiControllerBase : ControllerBase
    {
        protected IActionResult Failure(Error error)
        {
            var statusCode = ErrorStatusCodeMapper.Map(error);
            var problemDetails = new ProblemDetails
            {
                Status = statusCode,
                Title = GetTitle(statusCode),
                Detail = error.Message,
                Type = GetProblemType(statusCode),
                Instance = HttpContext.Request.Path
            };

            problemDetails.Extensions["code"] = error.Code;

            problemDetails.Extensions["traceId"] =  HttpContext.TraceIdentifier;

            return StatusCode(statusCode, problemDetails);

        }

        private static string GetTitle(int statusCode)
        {
            return statusCode switch
            {
                StatusCodes.Status400BadRequest => "درخواست نامعتبر",

                StatusCodes.Status401Unauthorized => "احراز هویت ناموفق",

                StatusCodes.Status403Forbidden => "دسترسی غیرمجاز",

                StatusCodes.Status404NotFound => "منبع پیدا نشد",

                StatusCodes.Status409Conflict => "تداخل در وضعیت منبع",

                _ => "خطای داخلی سرور"
            };
        }

        private static string GetProblemType(int statusCode)
        {
            return statusCode switch
            {
                StatusCodes.Status400BadRequest => "https://httpstatuses.com/400",

                StatusCodes.Status401Unauthorized => "https://httpstatuses.com/401",

                StatusCodes.Status403Forbidden => "https://httpstatuses.com/403",

                StatusCodes.Status404NotFound => "https://httpstatuses.com/404",

                StatusCodes.Status409Conflict => "https://httpstatuses.com/409",
                _ => "https://httpstatuses.com/500"
            };
        }
    }
}
