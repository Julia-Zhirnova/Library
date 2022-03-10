using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLib;
namespace ConsoleApp2
{
    class Program
    {
        // Генерация оценок, посещаемости на 10 дней вперед, начиная с текущей даты со списком переданных студентов 
        static List<Mark> GetMarks(DateTime now, List<string> students)
        {
            int n = students.Count;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("ФИО: {0}", students[i]);
            }
                

            for (int i = 0; i < 10; i++)
            {
                DateTime currentDate = DateTime.Now;
                DateTime date = currentDate.AddDays(i);
                Console.WriteLine("Day {0}: {1}", i+1, date);
            }
            Mark test_mark = new Mark();
            test_mark.date = DateTime.Now;
            string dateOnlyString = test_mark.date.ToShortDateString();
            Console.WriteLine("Only data: {0}", dateOnlyString);
            test_mark.Estimation = "5";
            //test_mark.Print();

            Mark test_mark2 = new Mark();
            test_mark2.date = DateTime.Now;
            test_mark2.Estimation = "3";
            //test_mark2.Print();

            List<Mark> marks = new List<Mark>();
            marks.Add(test_mark);
            marks.Add(test_mark2);

            marks.ForEach(p => Console.WriteLine($"Дата выставленной отметки: {p.date}, Оценка: {p.Estimation}"));

            return marks;
        }

        static void Main(string[] args)
        {
            string[] marks = new string[n];

            /*Console.WriteLine("Vvedite kolichestvo othenok");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] marks = new string[n];
            //string [] marks1;
            Console.WriteLine("Vvedite othenki");
            for (int i = 0; i < n; i++)
            {
                marks[i] = Console.ReadLine();
            }
            double result = utils.MinAVG(marks);
            Console.WriteLine("Result: {0}", result);*/

            /*Console.WriteLine("Generation studbilet");
            Console.WriteLine("");
            int year = 2000;
            int group = 185;
            string fio = "Zhirnova Julia Vitalevna";
            utils.GetStudNumber(year, group, fio);*/

            /*Students test_student = new Students();
            test_student.year = 2000;
            test_student.group = 185;
            test_student.fio = "Zhirnova Julia Vitalevna";
            test_student.Print();
                      

            Mark test_mark = new Mark();
            test_mark.date = DateTime.Now;
            string dateOnlyString = test_mark.date.ToShortDateString();
            Console.WriteLine("Only data: {0}", dateOnlyString);
            test_mark.Estimation = "5";
            //test_mark.Print();

            Mark test_mark2 = new Mark();
            test_mark2.date = DateTime.Now;
            test_mark2.Estimation = "3";
            //test_mark2.Print();

            List<Mark> marks = new List<Mark>();
            marks.Add(test_mark);
            marks.Add(test_mark2);
            marks.ForEach(p => Console.WriteLine($"Дата выставленной отметки: {p.date}, Оценка: {p.Estimation}"));*/

            List<Mark> marks_test = new List<Mark>();

            List<string> students = new List<string>();
            students.Add("student1");
            students.Add("student2");
            //Console.WriteLine("ФИО: {0}", students[0]);

            DateTime now = DateTime.Now;
            marks_test = GetMarks(now, students);

            Console.ReadKey();
        }
    
    }
}
