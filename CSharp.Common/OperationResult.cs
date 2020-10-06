using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Common
{
    public class OperationResult<T>
    {
        public OperationResult()
        {

        }

        public OperationResult(T result, string message) : this()
        {
            this.Result = result;
            this.Message = message;
        }

        public T Result { get; set; }
        public string Message { get; set; }

    }
}
