using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration_Automation
{
    internal class Program
    {
      

        static void Main(string[] args)
        {
           
            while (true)
            {
                Console.WriteLine("What action do you want to do?");
                Console.WriteLine("1) Student registration process.");
                Console.WriteLine("2) Student information update process.");
                Console.WriteLine("3) Student registration deletion process.");
                Console.WriteLine("4) Process of listing student information.");
                Console.WriteLine("0) Exit.");
                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Clear();
                    switch (choice)
                    {
                        case 1:
                            AddData.Add();
                            break;
                        case 2:
                            UpdateData.Update();
                            break;
                        case 3:
                            DeleteData.Delete();
                            break;
                        case 4:
                            ShowData.Show();
                            break;
                        case 0:
                            return; 
                        default:
                            Console.WriteLine("You made an invalid choice. Please choose again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

            }


        }
      
     

      
    }
}
