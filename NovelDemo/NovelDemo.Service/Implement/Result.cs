using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovelDemo.Service.Interface;

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
