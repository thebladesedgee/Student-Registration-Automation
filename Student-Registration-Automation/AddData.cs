using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration_Automation
{
    internal class AddData
    {
        public static void Add()
        {
            BackHome back = new BackHome();

            Console.WriteLine("how many student information will you add");
            int persons = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Enter the information of the students you want to enroll");
            for (int i = 0; i < persons; i++)
            {

                StudentInformation student = new StudentInformation();
                Context context = new Context();

                Console.WriteLine("please enter students name");
                string name = Console.ReadLine();
                student.name = name;

                Console.WriteLine("please enter students surname");
                string surname = Console.ReadLine();
                student.surname = surname;

                Console.WriteLine("please enter students age");
                int age = int.Parse(Console.ReadLine());
                student.age = age;

                Console.WriteLine("please enter students schoolnumber");
                int schoolnumber = int.Parse(Console.ReadLine());
                student.schoolnumber = schoolnumber;


                context.studentdata.Add(student);
                context.SaveChanges();
                Console.WriteLine("your information has been successfully saved");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();

            }

            back.AskToGoBackToMenu();
        }


    }
}
