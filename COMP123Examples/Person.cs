using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace COMP123Examples
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;

        //property
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (value != "Bob")
                    _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
        }
        //auto property
       // public int Age { get; set; }
       public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                    _age = 0;
                else
                    _age = value;

            }
        }
        public Person(string firstName, string lastName, int age=24)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age; 
        }

        public string GetFullName()
        {
            return $"{ _firstName} { _lastName}";
        }

        //static method
        public static string GetWords()
        {
            return "These are words";
        }

        //File write
        public void SaveToFile(string filePath)
        {
           // StreamWriter writer = new StreamWriter(filePath);
           using(StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(FirstName);
                writer.WriteLine(LastName);
            }
            //writer.Close();
        }
    }
}
