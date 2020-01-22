using System;
using System.Data.SqlClient;
using System.IO;
using System.Net;

namespace SanctionScanner.DeveloperPortal.WebSamples.Models
{
    public class Response
    {

        public HttpStatusCode HttpStatusCode { get; set; }
        public bool IsSuccess { get; set; } = false;
        //public bool IsBadRequestStatusCode { get; set; } = false;
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string ExtraInfo { get; set; }
        public object Result { get; set; }

        public static Response GetExceptionResponse(Exception ex)
        {
            if (ex is NullReferenceException)
                return new Response
                {
                    HttpStatusCode = HttpStatusCode.InternalServerError,
                    ErrorCode = "9000",
                    ErrorMessage = "Null Reference Exception"
                };
            else if (ex is FormatException)
                return new Response
                {
                    HttpStatusCode = HttpStatusCode.InternalServerError,
                    ErrorCode = "9001",
                    ErrorMessage = "Invalid Format"
                };

            else if (ex is SqlException)
                return new Response
                {
                    HttpStatusCode = HttpStatusCode.InternalServerError,
                    ErrorCode = "9002",
                    ErrorMessage = "Sql Error"
                };

            else if (ex is IndexOutOfRangeException)
                return new Response
                {
                    HttpStatusCode = HttpStatusCode.InternalServerError,
                    ErrorCode = "9003",
                    ErrorMessage = "IndexOutOfRangeException "
                };

            else if (ex is StackOverflowException)
                return new Response
                {
                    HttpStatusCode = HttpStatusCode.InternalServerError,
                    ErrorCode = "9004",
                    ErrorMessage = "StackOverflowException "
                };

            else if (ex is IOException)
                return new Response
                {
                    HttpStatusCode = HttpStatusCode.InternalServerError,
                    ErrorCode = "9005",
                    ErrorMessage = "File Operation IOException "
                };

            else
                return new Response
                {
                    HttpStatusCode = HttpStatusCode.InternalServerError,
                    ErrorCode = "9999",
                    ErrorMessage = "System Error"
                };

        }

        public static Response GetErrorResponse(HttpStatusCode httpStatusCode, string errorCode, string errorMessage)
        {

            return new Response
            {
                IsSuccess = false,
                HttpStatusCode = httpStatusCode,
                ErrorCode = errorCode,
                ErrorMessage = errorMessage
            };

        }

        public static Response GetResponse(HttpStatusCode httpStatusCode, object result)
        {

            return new Response
            {
                IsSuccess = true,
                HttpStatusCode = httpStatusCode,
                Result = result
            };

        }

        public static Response GetResponse(HttpStatusCode httpStatusCode)
        {

            return new Response
            {
                IsSuccess = true,
                HttpStatusCode = httpStatusCode,
                Result = null
            };

        }
    }

    public class JsonResponse
    {
        public string response { get; set; }
    }
}