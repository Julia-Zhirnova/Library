using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib
{
    public static class utils
    {
        // Вычисление среднего арифметического значения оценки в меньшую сторону 
        public static double MinAVG(string[] marks)
        {
            Console.WriteLine("String length: {0}", marks.Length);
            int[] mass = new int[marks.Length];
            double res = 0, sum = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                mass[i] = Convert.ToInt32(marks[i]);
                Console.WriteLine(mass[i]);
                sum = sum + mass[i];
            }
            res = sum / mass.Length;
            Console.WriteLine(res);
            int modres = Convert.ToInt32(res);
            Console.WriteLine(modres);
            modres = (int)res;
            return modres;
        }

        // Генерация номера студенческого билета в формате: yyyy.group.initial
        public static string GetStudNumber(int year, int group, string fio)
        {
            string[] s = fio.Replace(".", "").Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string LastName = s[0];
            string Name = s[1];
            string FatherName = s[2];
            Console.WriteLine("{0}.{1}.{2}{3}{4}", year, group, LastName[0], Name[0], FatherName[0]);
            string res = "The End";
            return res;
        }
    }
}
