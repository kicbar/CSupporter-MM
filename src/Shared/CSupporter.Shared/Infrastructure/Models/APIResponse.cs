﻿using System.Collections.Generic;

namespace CSupporter.Shared.Infrastructure.Models
{
    public class APIResponse
    {
        public bool IsSuccess { get; set; } = true;
        public object Result { get; set; }
        public string DisplayMessage { get; set; } = "";
        public List<string> ErrorMessages { get; set; }
    }
}
