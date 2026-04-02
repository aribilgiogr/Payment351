using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utils
{
    public class ApiResponse<T> : IApiResponse<T>
    {
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
        public IEnumerable<string>? Errors { get; set; }
        public DateTime ResponseTime { get; set; } = DateTime.UtcNow;
        public T? Data { get; set; }

        // Static factory methods for convenience
        public static ApiResponse<T> Success(T data, string? message = null) => new() { IsSuccess = true, Data = data, Message = message };

        public static ApiResponse<T> Success(string? message = null) => new() { IsSuccess = true, Message = message };

        public static ApiResponse<T> Failure(IEnumerable<string> errors, string? message = null) => new() { IsSuccess = false, Errors = errors, Message = message };

    }
}
