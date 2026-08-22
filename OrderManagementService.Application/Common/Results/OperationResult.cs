using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Application.Common.Results
{
    public class OperationResult
    {
        protected OperationResult(bool isSuccess, Error error)
        {
            if (isSuccess && error != Error.None ||
                !isSuccess && error == Error.None)
            {
                throw new ArgumentException("وضعیت نامعتبر برای شیء OperationResult", nameof(error));
            }

            IsSuccess = isSuccess;
            Error = error;
        }

        public static OperationResult Success() => new(true, Error.None);
        public static OperationResult Failure(Error error) => new(false, error);

        public bool IsSuccess { get; }
        public bool IsFailure => !IsSuccess;

        public Error Error { get; }
    }

    public class OperationResult<TData> : OperationResult
    {
        private readonly TData? _data;
        protected internal OperationResult(TData? data, bool isSuccess, Error error)
            : base(isSuccess, error)
        {
            _data = data;
        }

        public TData? Value
        {
            get
            {
                if (IsFailure)
                {
                    throw new InvalidOperationException("نمی‌توان به مقدار یک OperationResult ناموفق دسترسی پیدا کرد.");
                }
                return _data;
            }
        }

        public static OperationResult<TData> Success(TData value) => new(value, true, Error.None);
        public new static OperationResult<TData> Failure(Error error) => new(default, false, error);
    }
}
