using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Taisiya
{
    class User: IUser
    {
        private string login;


        public User(string login)
        {
            this.login = login;
        }

        public string Login
        {
            get { return login; }
            private set { login = value; }
        }


    }
}
