using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEncapsulationTasks2.Models
{
    internal class Employee
    {
        string _name;
        string _surname;
        string _username;
        byte _age;

        public string Name 
        {
            get => _name;
            set
            {
                if (String.IsNullOrEmpty(value)) 
                {
                    Console.WriteLine("Name cannot be empty");
                } else
                {
                    _name = $"{char.ToUpper(value[0])}{value.Substring(1)}";
                }
            }
        }
        public string Surname
        {
            get => _surname;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name cannot be empty");
                }
                else
                {
                    _surname = $"{char.ToUpper(value[0])}{value.Substring(1)}";
                }
            }
        }

        public string Username
        {
            get => _username;
            set
            {
                _username = value;//$"{Name}_{Surname}";
            }
        }

        public byte Age
        {
            get => _age;
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Age must be positive number and not 0");
                } else
                {
                    _age = value;
                }
            }
        }

        public Employee(string name, string surname, byte age) 
        {
            Name = name;
            Surname = surname;
            Age = age;
            Username = $"{Name}_{Surname}";
        }

        public override string ToString()
        {
            return $"Name: {Name} Surname: {Surname} Age: {Age} Username: {Username}";
        }
    }
}
