using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dipendenti_management.Dto
{
    public class LoginRequest
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}