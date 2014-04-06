using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIProject.Models
{
    public class ErrorModel
    {
        public string error { get; set; }

        public ErrorModel()
        {
            error = "Could not decode request: JSON parsing failed";
        }
    }
}