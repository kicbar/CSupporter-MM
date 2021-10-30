using System.Collections.Generic;

namespace CSupporter.Modules.View.Models
{
    public class ApiResponseDto
    {
        public bool IsSuccess { get; set; } = true;
        public object Result { get; set; }
        public string DisplayMessage { get; set; } = "";
        public List<string> ErrorMessage { get; set; }
    }
}
