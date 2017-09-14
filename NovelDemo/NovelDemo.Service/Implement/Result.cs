using NovelDemo.Service.Interface;
using System;

namespace NovelDemo.Service.Implement
{
    public class Result : IResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }

        public Result() : this(false)
        {

        }

        public Result(bool success)
        {
            Success = success;
        }
    }
}
