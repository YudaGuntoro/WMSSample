﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Domain
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; } = true;
        public T Data { get; set; }
        public string ErrorMessage { get; set; } = "";
    }
}
