using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppTest
{
    public class Students
    {
        public int group;
        public int year;
        public string fio;
    }

    public class Mark
    {
        
        public DateTime date;
        public string Estimation;
    }

    class Program
    {
        static List<Mark> GetMarks(DateTime now, List<string> students)
        {
           List<Mark> marks = new List<Mark>();

            for (int j = 0; j < 30; j++)
            {

                DateTime date = now.AddDays(j);
                Console.WriteLine(date);

                for (int i = 0; i < students.Count; i++)
                {
                    var random = new Random();
                    string[] Estimation = { "5", "4", "3", "2", "прогул", "болезнь" };

                    int index = random.Next(Estimation.Length);
                    Console.WriteLine("ФИО: {0}; Оценка: {1}", students[i], Estimation[index]);

                    Mark mark = new Mark();
                    mark.Estimation = Estimation[index];
                    mark.date = date;
                   
                    marks.Add(mark);

                }

            }
            //marks.ForEach(p => Console.WriteLine($"" + $"Дата выставленной отметки: {p.date}\n Студент: {p.Student},  Оценка: {p.Estimation}"));

            return marks;
        }

            public static int GetCountTruancy(List<Mark> marks)
        {
            DateTime date1 = new DateTime(2022, 03, 22, 0, 0, 0);
            var Truancy = from p in marks where p.Estimation == "прогул" where p.date >= date1 select p;
            int count = 0;
            foreach (Mark mark in Truancy)
            {
                //Console.WriteLine($"Студент: {mark.Student}, Оценка: {mark.Estimation}");
                count += 1;
            }
            Console.WriteLine($"Количество прогулов: {count}");
            return count;
        }
        // Вычисление количество пропусков по болезни за месяц за период
        public static int GetCountDicease(List<Mark> marks)
        {
            DateTime date1 = new DateTime(2022, 03, 22, 0, 0, 0);
            var Truancy = from p in marks where p.Estimation == "болезнь" where p.date >= date1 select p;
            int count = 0;
            foreach (Mark mark in Truancy)
            {
                //Console.WriteLine($"Студент: {mark.Student}, Оценка: {mark.Estimation}");
                count += 1;
            }
            Console.WriteLine($"Количество болезней: {count}");
            return count;
        }

        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;

            Random rnd = new Random();

            int year = rnd.Next(2000, 2004);
            int group = rnd.Next(190, 220);

            Students student1 = new Students();
            student1.fio = "Алибеков Мустафа";
            Students student2 = new Students();
            student2.fio = "Михаил Калашников";
            List<string> Students = new List<string>();
            Students.Add(student1.fio);
            Students.Add(student2.fio);


            List<Mark> res = GetMarks(now, Students);

            int res_1 = GetCountTruancy(res);
            int res_2 = GetCountDicease(res);
            /*Console.WriteLine(res);*/

        }

        /*        private static int GetCountDicease()
                {
                    throw new NotImplementedException();
                }

                private static int GetCountTruancy()
                {
                    throw new NotImplementedException();
                }*/
    }
}
