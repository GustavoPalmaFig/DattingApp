using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Erros
{
    public class ApiException
    {
        public ApiException(int statusCode, string message = null, string deatails = null)
        {
            StatusCode = statusCode;
            Message = message;
            Deatails = deatails;
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Deatails { get; set; }
    }
}