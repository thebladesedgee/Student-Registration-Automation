using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration_Automation
{
    internal class UpdateData
    {

        public static void Update()
        {
            Context context = new Context();
            StudentInformation student = new StudentInformation();
            BackHome back = new BackHome();

            Console.WriteLine("Which student do you want to update? choose an id");
            int find = int.Parse(Console.ReadLine());
            var specificdata = context.studentdata.Find(find);
            Console.WriteLine("Student Id: {0} Student Name: {1} Student Surname: {2} Student Age: {3} Student Number: {4}", specificdata.id, specificdata.name, specificdata.surname, specificdata.age, specificdata.schoolnumber);

            Console.WriteLine("please enter new students name");
            string name = Console.ReadLine();
            specificdata.name = name;

            Console.WriteLine("please enter new students surname");
            string surname = Console.ReadLine();
            specificdata.surname = surname;

            Console.WriteLine("please enter new students age");
            int age = int.Parse(Console.ReadLine());
            specificdata.age = age;

            Console.WriteLine("please enter new students schoolnumber");
            int schoolnumber = int.Parse(Console.ReadLine());
            specificdata.schoolnumber = schoolnumber;


            context.studentdata.Add(student);
            context.SaveChanges();
            Console.WriteLine("your information has been successfully saved");
            System.Threading.Thread.Sleep(2000);

            back.AskToGoBackToMenu();
        }

    }
}
