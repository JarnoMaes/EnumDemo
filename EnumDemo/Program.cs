using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region EnumDemo
            ////workDays d = (workDays);
            ////Console.WriteLine(d);

            ////workDays d = workDays.Monday;
            ////Console.WriteLine(d);



            ////Enumarate values 0,1,2,..
            //foreach (int i in Enum.GetValues(typeof(workDays)))
            //{
            //    Console.WriteLine(i);
            //}

            ////Enumarate Names  Monday,Tuesday,...
            //foreach (string s in Enum.GetNames(typeof(workDays)))
            //{
            //    Console.WriteLine(s);
            //}
            #endregion


            //Console.WriteLine("Select a day please: ");
            //Days d = Days.Tuesday;

            //int day = (int)d;
            //Console.WriteLine(day);

        }
    }
}
