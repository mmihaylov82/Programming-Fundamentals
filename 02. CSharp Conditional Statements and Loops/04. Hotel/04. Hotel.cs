using System;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string Month = Console.ReadLine();
            int NumberOfNights = int.Parse(Console.ReadLine());

            double studioPrice = 0.0;
            double doublePrice = 0.0;
            double suitePrice = 0.0;

            switch (Month)
            {
                case "May":
                case "October":
                    {
                        if (NumberOfNights > 7)
                        {
                            studioPrice = 50 * 0.95;
                        }
                        else
                        {
                            studioPrice = 50.0;
                        }
                        doublePrice = 65;
                        suitePrice = 75;
                        break;
                    }
                case "June":
                case "September":
                    {
                        studioPrice = 60;
                        if (NumberOfNights > 14)
                        {
                            doublePrice = 72 * 0.9;
                        }
                        else
                        {
                            doublePrice = 72;
                        }
                        suitePrice = 82;
                        break;
                    }
                case "July":
                case "August":
                case "December":
                    {
                        studioPrice = 68;
                        doublePrice = 77;
                        if (NumberOfNights > 14)
                        {
                            suitePrice = 89 * 0.85;
                        }
                        else
                        {
                            suitePrice = 89;
                        }
                        break;
                    }

                default:
                    break;
            }

            if ((NumberOfNights > 7) && (Month == "September" || Month == "October"))
            {
                Console.WriteLine($"Studio: {(studioPrice * (NumberOfNights - 1)):f2} lv.");
            }
            else
            {
                Console.WriteLine($"Studio: {(studioPrice * NumberOfNights):f2} lv.");
            }
            Console.WriteLine($"Double: {(doublePrice * NumberOfNights):f2} lv.");
            Console.WriteLine($"Suite: {(suitePrice * NumberOfNights):f2} lv.");
        }
    }
}