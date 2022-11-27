using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Account
{
    public class User : IAccount
    {
        private int _counter =0;
        private int _id { get;}
        private string _password;

        public int Id { get { return _id; } }
        string Fullname { get; set; }
        string Email{get; set;}
        public string Password 
        {
            get
            { 
                return this._password;
            }
            set 
            {
                PasswordChecker(value);

                if (PasswordChecker(value) == true)
                {
                    this._password = value;
                    Console.WriteLine("Password is correct");
                }
                else
                {
                    this._password = null;
                    Console.WriteLine("Password is incorrect");
                }
            }
        }

        public User(string mail,string pass, string fullname = null)
        {
            _counter++;
            this.Email = mail;
            this.Password = pass;
            this._id = _counter;
            this.Fullname = fullname;
        }

        public bool PasswordChecker(string Pass)
        {
            bool Check;
            
            Regex num = new Regex(@"[0-9]+");
            Regex up = new Regex(@"[A-Z]+");
            Regex low = new Regex(@"[a-z]+");

            Check = num.IsMatch(Pass) && up.IsMatch(Pass) && low.IsMatch(Pass) && Pass.Length > 8;
            
            return Check;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Fullname {this.Fullname} Email {this.Email} Password {_password} Id {_id}");
        }
    }
}
