using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHOP_API.Model
{
    public class LoginData
    {
        private string user;
        private string pwd;

        public string User { get => user; set => user = value; }
        public string Pwd { get => pwd; set => pwd = value; }
    }
}
