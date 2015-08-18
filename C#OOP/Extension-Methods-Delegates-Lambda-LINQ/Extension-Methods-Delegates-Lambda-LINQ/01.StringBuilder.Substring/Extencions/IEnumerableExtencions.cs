namespace _01.StringBuilder.Substring.Extencions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /*
        Problem 2. IEnumerable extensions

        Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
     */

    public static class IEnumerableExtencions
    {
        public static T Sum<T> (this IEnumerable<T> elements) where T:struct
        {
            dynamic sum = 0;
            foreach (T element in elements)
            {
                sum += element;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> elements) where T : struct
        {
            dynamic product = 1;
            foreach (T element in elements)
            {
                product *= element;
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> elements) where T : struct
        {
            dynamic min = elements.First();
            foreach (T element in elements)
            {
                if (min > element)
                {
                    min = element;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> elements) where T : struct
        {
            dynamic max = elements.First();
            foreach (T element in elements)
            {
                if (max < element)
                {
                    max = element;
                }
            }
            return max;
        }

        public static T Average<T>(this IEnumerable<T> elements) where T : struct
        {
            dynamic average = 0;
            foreach (T element in elements)
            {
                average += element;
            }
            average = average / (elements.Count());
            return average;
        }
    }
    
}
