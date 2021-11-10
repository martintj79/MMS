using MMS.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MMS.Web.Models
{
    public class GreetingViewModel
    {
        public IEnumerable<Member> Members { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
    }
}