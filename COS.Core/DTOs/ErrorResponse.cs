using System.Collections.Generic;

namespace COS.Core.DTOs
{
    public class ErrorResponse
    {
        public IEnumerable<string> Errors { get; set; } = new List<string>();
        public string Message { get; set; }

    }
}