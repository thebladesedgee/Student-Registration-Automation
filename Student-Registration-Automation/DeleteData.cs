using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration_Automation
{
    internal class DeleteData
    {

        public static void Delete()
        {
            Context context = new Context();
            StudentInformation student = new StudentInformation();
            BackHome back = new BackHome();

            Console.WriteLine("do you want to delete one student or all students\n1)single\n2)all");
            int partialdelete = int.Parse(Console.ReadLine());
            if (partialdelete == 1)
            {
                Console.WriteLine("Which student do you want to delete? choose an id");
                int find = int.Parse(Console.ReadLine());
                var deletedata = context.studentdata.Find(find);
                Console.WriteLine("Student Id: {0} Student Name: {1} Student Surname: {2} Student Age: {3} Student Number: {4}", deletedata.id, deletedata.name, deletedata.surname, deletedata.age, deletedata.schoolnumber);
                if (deletedata != null)
                {
                    context.studentdata.Remove(deletedata);
                    Console.WriteLine("The student has been successfully deleted.");
                }
                context.SaveChanges();
            }
            else
            {
                var list = context.studentdata.ToList();
                foreach (var category in list)
                {
                    context.studentdata.Remove(category);
                }
                Console.WriteLine("All students have been successfully deleted.");
                context.SaveChanges();

            }

            back.AskToGoBackToMenu();

        }
    }
}
