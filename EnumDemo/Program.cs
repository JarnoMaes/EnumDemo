using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    enum workDays
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
           
            //workDays d = (workDays);
            //Console.WriteLine(d);

            //workDays d = workDays.Monday;
            //Console.WriteLine(d);

            
            
            //Enumarate values 0,1,2,..
            foreach (int i in Enum.GetValues(typeof(workDays)))
            {
                Console.WriteLine(i);
            }
            
            //Enumarate Names  Monday,Tuesday,...
            foreach (string s in Enum.GetNames(typeof(workDays)))
            {
                Console.WriteLine(s);
            }



        }
    }
}
