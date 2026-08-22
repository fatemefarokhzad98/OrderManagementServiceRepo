namespace OrderManagementService.Api.Models.Common;

public class ApiResponse<T>
{
    public bool IsSuccess { get; init; }

    public T? Data { get; init; }

    public ApiError? Error { get; init; }

    public static ApiResponse<T> Success(T data)
    {
        return new ApiResponse<T>
        {

            IsSuccess = true,
            Data = data
        };
    }

    public static ApiResponse<T> Failure(string code, string message)
    {
        return new ApiResponse<T>
        {
            IsSuccess = false,
            Error = new ApiError(code, message)
        };
    }
}

public record ApiError(string Code, string Message);

