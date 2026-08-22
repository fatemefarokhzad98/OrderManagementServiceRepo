using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Application.Common.Results
{
    public record Error
    {
        public Error(string code, string message)
        {
            Code = code;
            Message = message;
            Metadata = [];            
        }

        public Error(string code, string message, Dictionary<string, object> metadata)
        {
            Code = code;
            Message = message;
            Metadata = metadata;
        }

        public string Code { get; }
        public string Message { get; }
        public Dictionary<string, object> Metadata { get; }


        public static readonly Error None = new(string.Empty, string.Empty);
        public static Error NullValue() => new("Error.NullValue", "مقدار نمی‌تواند خالی باشد.");
        public static Error NullValue(string message) => new("Error.NullValue", message);
        public static Error Validation(string message) => new("Error.Validation", message);
    }
}
