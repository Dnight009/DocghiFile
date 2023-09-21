using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace DocghiFile.Models
{
    public class Email
    {
        public String From { get; set; }
        public String To { get; set; }
        public String Subject { get; set; }
        public String Body { get; set; }

    }
}