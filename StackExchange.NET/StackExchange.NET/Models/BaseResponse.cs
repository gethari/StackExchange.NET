using System;

namespace StackExchange.NET.Models
{
    public class BaseResponse<T>
    {
        public bool Success { get; set; }
        public Data<T> Data { get; set; }
        public Exception Exception { get; set; }
    }
}