using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Area_for_mvc.Areas.Account.Model
{
    public class Account
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}