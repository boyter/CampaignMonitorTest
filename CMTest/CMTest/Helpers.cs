namespace CMTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using CMTest.Exceptions;

    public class Helpers
    {
        /// <summary>
        /// REQUIREMENT 2
        /// Assumes that we only want results for positive integers
        /// </summary>
        public List<int> PositiveDivisors(int input)
        {
            var result = new List<int>();

            if (input <= 0)
            {
                return result;
            }

            for (var i = 1; i <= (input / 2); i++)
            {
                if (input % i == 0)
                {
                    result.Add(i);
                }
            }

            result.Add(input);
            return result;
        }

        /// <summary>
        /// REQUIREMENT 3
        /// Assumes that triangles cannot have a side of length zero for the 
        /// "Inputs that cannot form a valid triangle" requirement and throw exception for that
        /// Assumes that Heron's Formula is an acceptable algorithm to implement
        /// </summary>
        public double CalculateTriangleArea(int side1, int side2, int side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new InvalidTriangleException("Sides must be > 0");
            }

            // Using Heron's Formula
            var semiperimeter = (side1 + side2 + side3) / 2;
            var result = semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3);

            return Math.Sqrt(result);
        }

        /// <summary>
        /// REQUIREMENT 4
        /// </summary>
        public List<int> MostCommon(List<int> common)
        {
            var counts = common.GroupBy(x => x).OrderByDescending(x => x.Count());
            var maxcounts = counts.Where(x => x.Count() == counts.First().Count());

            return maxcounts.Select(x => x.Key).ToList();
        }
    }
}
