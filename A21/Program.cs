using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A21
{
    internal class Program
    {
        public static void Nameofdays(List<string> days)
        {
            Console.WriteLine("Days In a Week");
            foreach (string day in days)
            {
                Console.WriteLine(day);
                Thread.Sleep(2000);
            }
        }
        public static void AllMonths(List<string> months)
        {
            Console.WriteLine("Months:");
            foreach(string month in months)
            {
                Console.WriteLine(month);
                Thread.Sleep(2000);
            }
        }
        public static void DFruits(List<string> fruits)
        {
            Console.WriteLine("Fruits");
            foreach(string i in fruits)
            {
                Console.WriteLine(i);
            }
        }
        public static void Meanings(Dictionary<string, string> means)
        {
            Console.WriteLine("Words And Meanings");
            foreach(var meaning in means)
            {
                Console.WriteLine(meaning);

            }
        }
        static void Main(string[] args)
        {
            List<string> Fruits = new List<string>()
            { "Banana","Apple","Strawberry","Mango","Peach","BlueBerry","PineApple","Orange","Guva","Grapes"};
            List<string> Days=new List<string>()
            { "Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};
            List<string> Months=new List<string>()
            { "January","February","March","April","May","June","July","August","September","October","November","December"};
            Dictionary<string,string> Means= new Dictionary<string,string>();
            Means.Add("Increment", "Increasing value");
            Means.Add("Decrement", "Decreasing value");
            Means.Add("Loops", "Running piece of code for certain mnumber of times");
            Means.Add("laptop", "Electronic device");
            Means.Add("List", "Collection of values of certain datatype");
            var starttime=DateTime.Now;
            Nameofdays(Days);
            var endtime=DateTime.Now;
            Console.WriteLine($"Start time : {starttime}, End Time : {endtime}");
            Thread.Sleep(5000);
            var st1= DateTime.Now;
            AllMonths(Months);
            var et1= DateTime.Now;
            Console.WriteLine($"Start time : {st1}, End Time : {et1}");
            Thread t1 = new Thread(() => DFruits(Fruits));
            Thread t2= new Thread(() => Meanings(Means));
            t1.Start();
            t2.Start();
            Console.ReadKey ();

        }
    }
}
