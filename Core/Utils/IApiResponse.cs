using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utils
{
    public interface IApiResponse
    {
        bool IsSuccess { get; set; }
        string? Message { get; set; }
        IEnumerable<string>? Errors { get; set; }
        DateTime ResponseTime { get; set; }
    }

    public interface IApiResponse<T> : IApiResponse
    {
        T? Data { get; set; }
    }
}
