using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExample
{
    public class Baby
    {

        private string _name;
        private string _surname;
        private DateTime _birthday;


        public Baby() {

            Console.WriteLine($"Ingaaaa");
            _birthday = DateTime.Now;
        }
        public Baby( string name,string surname) {
        
            _name = name;
            _surname = surname;
            Console.WriteLine($"Ingaaaa");
            _birthday = DateTime.Now;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; }


        public void ShowInfo()
        {

            Console.WriteLine($"Name:{_name}\nSurname:{_surname}\nBirthday:{_birthday}");
        }
    }

    
}
