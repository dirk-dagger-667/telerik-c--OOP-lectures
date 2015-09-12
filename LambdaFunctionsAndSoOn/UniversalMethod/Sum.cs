//* By using delegates develop an universal static method to calculate the sum of infinite convergent series with given precision depending on a function of its term. By using proper functions for the term calculate with a 2-digit precision the sum of the infinite series:
//    1 + 1/2 + 1/4 + 1/8 + 1/16 + …
//    1 + 1/2! + 1/3! + 1/4! + 1/5! + …
//    1 + 1/2 - 1/4 + 1/8 - 1/16 + … 


namespace SumOfInfiniteConvergentSeries
{
    using System;
    public class Sum
    {
        public static double CalculateSum(double start, double step, bool changeSign, double stepIncrement, Func<double, double, double> nextMemeber)
        {
            double oldSum = 0;
            double nextMember = NextMember(start, step);
            double currentSum = start + 1 / nextMember;
            if (changeSign)
            {
                nextMember = -nextMember;
            }
            step += stepIncrement;
            double difference = currentSum - oldSum;
            while (Math.Abs(difference) > 0.00000001)
            {
                oldSum = currentSum;
                nextMember = NextMember(nextMember, step);
                currentSum += 1 / nextMember;
                if (changeSign)
                {
                    nextMember = -nextMember;
                }
                step += stepIncrement;
                difference = currentSum - oldSum;
            }
            return currentSum;
        }
        public static double NextMember(double start, double step)
        {
            return start * step;
        }
    }
}

