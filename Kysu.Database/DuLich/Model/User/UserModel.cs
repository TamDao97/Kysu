using System;
using System.Collections.Generic;
using System.Text;

namespace Kysu.DB.DuLich.Model.User
{
    public class UserModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Avatar { get; set; }
        public int Type { get; set; }
    }
}
