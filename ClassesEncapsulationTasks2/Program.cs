using ClassesEncapsulationTasks2.Models;

namespace ClassesEncapsulationTasks2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to create a company?(Yes/Y)");
            string response = Console.ReadLine().ToLower();
            if (response == "yes" || response == "y")
            {
                Console.WriteLine("Write name of company: ");
                string companyName = Console.ReadLine();
                Company company = new Company(companyName);
                Console.WriteLine("How many users you want to add?");
                int numberOfUsers = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numberOfUsers; i++)
                {
                    Console.WriteLine("Enter name of User:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter surname of User:");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Enter age of User:");
                    byte age = Convert.ToByte(Console.ReadLine());
                    company.AddUser(name, surname, age);
                }
                Console.WriteLine("Which user you want to remove?(write anything if you dont want)");
                string userToRemove = Console.ReadLine();
                company.RemoveUser(userToRemove);
                Console.WriteLine("All users: ");
                company.GetAllUsers();
                Console.WriteLine("Which user you want to update?(write anything if you dont want)");
                string userToUpdate = Console.ReadLine();
                company.UpdateUser(userToUpdate);
                Console.WriteLine("All users: ");
                company.GetAllUsers();
            }
            else
            {
                return;
            }
            //Company company = new Company("Pizdec");
            //company.AddUser("Mikayil", "Adilov", 20);
            //company.AddUser("Rufat", "Azizov", 20);
            //company.GetAllUsers();
            //Console.WriteLine("Remove mikayil");
            //company.RemoveUser("Mikayil_Adilov");
            //company.GetAllUsers();
            //Console.WriteLine("Update Rufat");
            //company.UpdateUser("Rufat_Azizov");
            //company.GetAllUsers();

        }
    }
}