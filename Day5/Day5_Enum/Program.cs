using System;

namespace Day5_Enum
{
    enum SeasonEnum
    {
        Winter,
        Spring,
        Summer,
        Autumn
    }

    enum WeekdaysEnum
    {
        Mon,
        Tue,
        Wed,
        Thu,
        Fri,
        Sat,
        Sun
    }

    class Program
    {
        static void Main(string[] args)
        {            
            WeekdaysEnum weekday = WeekdaysEnum.Sat;

            //Create a program which will tell us to work on workdays and relax on weekdays
            switch (weekday)
            {
                case WeekdaysEnum.Mon:
                case WeekdaysEnum.Tue:
                case WeekdaysEnum.Wed:
                case WeekdaysEnum.Thu:
                case WeekdaysEnum.Fri:
                    //this code will work for all of the work days
                    Console.WriteLine("WORK");
                    break;
                case WeekdaysEnum.Sat:
                case WeekdaysEnum.Sun:
                    //this code will work for all of the weekend days
                    Console.WriteLine("RELAX");
                    break;
                default:
                    break;
            }

            //switch (weekday)
            //{
            //    case WeekdaysEnum.Mon:
            //        Console.WriteLine("Hard work");
            //        break;
            //    case WeekdaysEnum.Tue:
            //        Console.WriteLine("Lazy work");
            //        break;
            //    case WeekdaysEnum.Wed:
            //        break;
            //    case WeekdaysEnum.Thu:
            //        break;
            //    case WeekdaysEnum.Fri:
            //        Console.WriteLine("Finally party day");
            //        break;
            //    case WeekdaysEnum.Sat:
            //        Console.WriteLine("Sleeping till dawn");
            //        break;
            //    case WeekdaysEnum.Sun:
            //        break;
            //    default:
            //        break;
            //}

            int seasonNr = 2; //user inputted
            SeasonEnum seasonFromUser = (SeasonEnum)seasonNr;
            Console.WriteLine(seasonFromUser);

            //SeasonEnum season = SeasonEnum.Summer;

            //if (season == SeasonEnum.Summer)
            //{
            //    Console.WriteLine("It should be hot!");
            //}
        }
    }
}
