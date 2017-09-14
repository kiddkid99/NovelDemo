using System;

namespace NovelDemo.Service.Interface
{
    public interface IResult
    {
        bool Success { get; set; }

        string Message { get; set; }

        Exception Exception { get; set; }

    }
}
