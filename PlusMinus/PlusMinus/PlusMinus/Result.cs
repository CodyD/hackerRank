using System;
using System.Collections.Generic;

namespace PlusMinus
{
    public class Result
    {

        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */


        public static void plusMinus(List<int> arr)
        {
            var data = Compute(arr);
            Console.Write(data.ToString());
        }

        /// <summary>
        /// Calculates the ratio of the array's elements which are
        /// positive, negative, and zero.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>The decimal values of each fraction with
        /// 6 places after the decimal. </returns>
        public static RatioStatistic Compute(List<int> arr)
        {
            var ratio = new RatioStatistic();
            foreach(int item in arr)
            {
                if(item == 0)
                {
                    ratio.AddZero();
                } else if(item > 0)
                {
                    ratio.AddPositive();
                } else
                {
                    ratio.AddNegative();
                }
            }

            return ratio;
        }
    }
}
