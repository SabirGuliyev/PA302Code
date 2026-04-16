using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EncapsulationExample.Models
{

    internal class User
    {
        string _name;
        string _surname;
        string _userName;
        string _password;

        public string Name
        {
            get {

                return _name;
            }
            set {

                value = value.Trim();

                if (value.Length > 2 &&value.Length<50)
                {
                    _name = value;
                }


            }
        }


        public string Surname
        {
            get { 
                return _surname;
            }
            set {
                value = value.Trim();

                if (value.Length > 2)
                {
                    _surname = value;
                }
            }
        }

        public string UserName
        {
            get
            {
                return _userName;
            }
          
           
        }

        public string Password
        {
            set
            {
                _password = value;
            }
        }




        public User(string name, string surname, string password="Salam123")
        {
            Name = name;
            Surname = surname;

            _userName = string.Concat(name, ".", surname);

            Password = password;

        }








        //public string GetName()
        //{
        //    return Name.ToLower();
        //}

        //public void SetName(string name)
        //{
        //    name = name.Trim();

        //    if (name.Length > 2)
        //    {
        //        Name = name;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Ad yanlish");
        //    }
        //}



        public void PrintInfo()
        {
            Console.WriteLine($"{Name} {Surname}");
        }

    }
}
