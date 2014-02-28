using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BussinesObjects
{

   public class User
    {
        private Int64 _id;

        public Int64 Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _lastname;

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        private string _psw;

        public string Psw
        {
            get { return _psw; }
            set { _psw = value; }
        }
    }
}
