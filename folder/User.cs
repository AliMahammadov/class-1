using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_task.folder
{
    internal class User
    {
        string _userName;
        string _pasword;
        bool _isSignedIn;




        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }


        public string Pasword
        {
            get { return _pasword; }

            set { _pasword = value; }
        }

        public bool IsSignedIn
        {
            get { return _isSignedIn; }
            set { _isSignedIn = value; }
        }



        public bool CheckPassword(string pasword)
        {
            return _pasword == pasword;

        }

    }
}
