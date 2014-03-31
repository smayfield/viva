using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Viva.Api.Models
{
    public class Status
    {
        public int Id { get; set; }
        public DateTime PostedOn { get; set; }
        public User User { get; set; }
        public string Content { get; set; }
        public Network Network { get; set; }
    }

}