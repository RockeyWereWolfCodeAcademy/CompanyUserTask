using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEncapsulationTasks2.Models
{
    internal class Company
    {
        string _name;
        Employee[] _employees = new Employee[0];

        public string Name 
        { get => _name;
            set 
            {
                _name = value;
            }
        }

        public void AddUser (string name, string surname, byte age)
        {
            Array.Resize(ref _employees, _employees.Length + 1);
            _employees[_employees.Length-1] = new Employee(name, surname, age);  
        }

        public void RemoveUser (string username)
        {
            int removeIndex = -1;
            for (int n = 0; n < _employees.Length; n++)
            {
                if (_employees[n].Username == username)
                {
                    removeIndex = n;
                    break;
                }
            }
            if (removeIndex == -1)
            {
                Console.WriteLine("There is no employee with this username");
                return;
            }
            for (int a = removeIndex; a < _employees.Length - 1; a++)
            {
                _employees[a] = _employees[a + 1];
            }
            Array.Resize(ref _employees, _employees.Length - 1);
        }

        public void GetUser(string username)
        {
            int findIndex = -1;
            for (int i = 0; i < _employees.Length; i++)
            {
                if (_employees[i].Username == username)
                {
                    findIndex = i;
                    break;
                }
            }
            if (findIndex == -1)
            {
                Console.WriteLine("There is no employee with this username");
                return;
            }
            Console.WriteLine(_employees[findIndex]);
            //Console.WriteLine(_employees[findIndex].Name);
            //Console.WriteLine(_employees[findIndex].Surname);
            //Console.WriteLine(_employees[findIndex].Age);
            //Console.WriteLine(_employees[findIndex].Username);
        }

        public void GetAllUsers()
        {
            for (int i = 0; i < _employees.Length; i++)
            {
                Console.WriteLine(_employees[i]);
            }
            
        }

        public void UpdateUser(string username)
        {
            int findIndex = -1;
            for (int i = 0; i < _employees.Length; i++)
            {
                if (_employees[i].Username == username)
                {
                    findIndex = i;
                    break;
                }
            }
            if (findIndex == -1)
            {
                Console.WriteLine("There is no employee with this username");
                return;
            }
            Console.WriteLine("What you want to change?(Name, Surname or Age)");
            string response = Console.ReadLine().ToLower();
            switch (response)
            {
                case "name":
                    Console.WriteLine("Enter new Name");
                    _employees[findIndex].Name = Console.ReadLine();
                    _employees[findIndex].Username = $"{_employees[findIndex].Name}_{_employees[findIndex].Surname}";
                    break;
                case "surname":
                    Console.WriteLine("Enter new Surname");
                    _employees[findIndex].Surname = Console.ReadLine();
                    _employees[findIndex].Username = $"{_employees[findIndex].Name}_{_employees[findIndex].Surname}";
                    break;
                case "age":
                    Console.WriteLine("Enter new Age");
                    _employees[findIndex].Age = Convert.ToByte(Console.ReadLine());
                    break;
                default: 
                    Console.WriteLine("There is no such parameter");
                    break;
            }
        }
 

        //public Employee Employee {
        //    get
        //    {
                

        //    }
        //    set
        //    {
                 
        //    } 
        //}

        public Company(string name) 
        {
            Name = name;
        }
    }
}
