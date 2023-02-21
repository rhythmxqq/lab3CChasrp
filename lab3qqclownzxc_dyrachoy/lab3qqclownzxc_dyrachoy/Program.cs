using System;

namespace lab3qqclownzxc_dyrachoy
{
    class Program
    {
        enum Days
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday

        }
        enum Time
        {
            night ,
            morning ,
            evening ,
            day
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите день недели числом от 1-7:");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите время суток: День,Ночь,Вечер,утро");
            int times = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сейчас: ");
            printDay(day);
            printTime(times);

            
            
        }

        static void printDay(int day)
        {
            Days days =(Days)day;

            switch (days)
            {
                case Days.Monday:
                    Console.Write("Понедельник");
                    break;
                case Days.Tuesday:
                    Console.Write("Вторник");
                    break;
                case Days.Wednesday:
                    Console.Write("Среда");
                    break;
                case Days.Thursday:
                    Console.Write("Четверг");
                    break;
                case Days.Friday:
                    Console.Write("Пятница");
                    break;
                case Days.Saturday:
                    Console.Write("Суббота");
                    break;
                case Days.Sunday:
                    Console.Write("Воскресенья");
                    break;
                default:
                    break;
            }
        }
        static void printTime(int times)
        {
            Time time = new Time();

            if ((times <= 12 & times >= 7))
            {
                Console.Write(" Утро");     
            }
            if ((times <= 18 & times >= 13))
            {
                Console.Write(" День");
            }
            if ((times <= 23 & times > 18))
            {
                Console.Write(" Вечер");
            }
            if ((times <= 6 & times > 0))
            {
                Console.Write(" Ночь");
            }
           
        }
}
}
