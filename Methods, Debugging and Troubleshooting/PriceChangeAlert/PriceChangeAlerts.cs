using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double significanceTreshold = double.Parse(Console.ReadLine());
        double previusInput = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double currentNum = double.Parse(Console.ReadLine());
            double difference = GetDifference(previusInput, currentNum);
            bool isSignificantDifference = CheckForDiff(difference, significanceTreshold*100);
            string message = GetDiffMessage(currentNum, previusInput, difference, isSignificantDifference);
            Console.WriteLine(message);
            previusInput = currentNum;
        }
    }

    private static string GetDiffMessage(double currentNum, double previusInput, double difference, bool etherTrueOrFalse)
    {
        string message = "";
        if (difference == 0)
        {
            message = string.Format("NO CHANGE: {0}", currentNum);
        }
        else if (!etherTrueOrFalse)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", previusInput, currentNum, difference);
        }
        else if (etherTrueOrFalse && (difference > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", previusInput, currentNum, difference);
        }
        else if (etherTrueOrFalse && (difference < 0))
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", previusInput, currentNum, difference);
        return message;
    }
    private static bool CheckForDiff(double significanceTreshold, double isDiff)
    {
        if (Math.Abs(significanceTreshold) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double GetDifference(double l, double currentNum)
    {
        double r = (currentNum - l) / l * 100;
        return r;
    }
}
