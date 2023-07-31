using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration_Automation
{
    internal class ShowData
    {

        public static void Show()
        {
            Context context = new Context();
            StudentInformation student = new StudentInformation();
            BackHome back = new BackHome();

            Console.WriteLine("Do you want to list a single student or all students?\n1)single\n2)all");
            int partialshow = int.Parse(Console.ReadLine());
            Console.Clear();
            if (partialshow == 1)
            {
                Console.WriteLine("Which student do you want to list? choose an id");
                int find = int.Parse(Console.ReadLine());
                var specificdata = context.studentdata.Find(find);
                Console.WriteLine("Student Id: {0} Student Name: {1} Student Surname: {2} Student Age: {3} Student Number: {4}", specificdata.id, specificdata.name, specificdata.surname, specificdata.age, specificdata.schoolnumber);



            }
            else
            {

                var list = context.studentdata.ToList();

                foreach (var category in list)
                {
                    Console.WriteLine("Student Id: {0} Student Name: {1} Student Surname: {2} Student Age: {3} Student Number: {4}", category.id, category.name, category.surname, category.age, category.schoolnumber);
                }



            }

            back.AskToGoBackToMenu();
        }

    }
}
