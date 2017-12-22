using System;

namespace Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nightsCount = int.Parse(Console.ReadLine());
            double studioPrice;
            double doublePrice;
            double suitePrice;

            if (month == "May" || month == "October")
            {
                if (nightsCount > 7)
                {
                    if (month == "October")
                    {
                        studioPrice = (nightsCount - 1) * 50 * 0.95;
                    }
                    else
                    {
                        studioPrice = nightsCount * 50 * 0.95;
                    }
                }
                else
                {
                    studioPrice = nightsCount * 50;
                }
                doublePrice = nightsCount * 65;
                suitePrice = nightsCount * 75;
;           }
            else if (month == "June" || month == "September")
            {
                if (month == "September" && nightsCount >7)
                {
                    studioPrice = (nightsCount - 1) * 60;
                }
                else
                {
                    studioPrice = nightsCount * 60;
                }
                if (nightsCount > 14)
                {
                    doublePrice = nightsCount * 72 * 0.9;
                }
                else
                {
                    doublePrice = nightsCount * 72;
                }
                suitePrice = nightsCount * 82;
            }
            else
            {
                studioPrice = nightsCount * 68;
                doublePrice = nightsCount * 77;
                if (nightsCount > 14)
                {
                    suitePrice = nightsCount * 89 * 0.85;
                }
                else
                {
                    suitePrice = nightsCount * 89;
                }
            }

            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
            Console.WriteLine($"Double: {doublePrice:F2} lv.");
            Console.WriteLine($"Suite: {suitePrice:F2} lv.");
        }
    }
}
