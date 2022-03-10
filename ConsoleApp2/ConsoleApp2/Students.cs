using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // класс студентов для генерации оценок: группа, год поступления, ФИО.
    class Students
    {
        public int year;
        public int group;
        public string fio;
        public void Print()
        {
            Console.WriteLine($"Год поступления: {year}  Группа: {group} ФИО: {fio}");
        }
    }
    
    // класс оценок
    class Mark
    {
        public DateTime date; // дата выставленной отметки
        public string Estimation; // оценка, отсутствие (по уважительной причине), прогул, болезнь.
       // public string Estimationt { get; }
     //   public Mark(string estimationt) => Estimationt = estimationt;
        public void Print()
        {
            Console.WriteLine($"Дата выставленной отметки: {date}  Оценка: {Estimation}");
        }
    }

}
