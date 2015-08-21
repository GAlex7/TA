namespace Check
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class ExtMethods
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            return new StringBuilder(str.ToString().Substring(index, length));
        }

        #region IEnumerable Sum, Product, Min, Max, Average

        public static T Sum<T>(this IEnumerable<T> collection)
        {
            double result = 0;
            foreach (var item in collection)
            {
                result += double.Parse(item.ToString());
            }
            return (T)Convert.ChangeType(result, typeof(T));
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            double result = 1;
            foreach (var item in collection)
            {
                result *= double.Parse(item.ToString());
            }
            return (T)Convert.ChangeType(result, typeof(T));
        }

        public static T Min<T>(this IEnumerable<T> collection)
        {
            double result = double.MaxValue;
            foreach (var item in collection)
            {
                if (result < double.Parse(item.ToString()))
                    result = double.Parse(item.ToString());
            }
            return (T)Convert.ChangeType(result, typeof(T));
        }

        public static T Max<T>(this IEnumerable<T> collection)
        {
            double result = double.MinValue;
            foreach (var item in collection)
            {
                if (result > double.Parse(item.ToString()))
                    result = double.Parse(item.ToString());
            }
            return (T)Convert.ChangeType(result, typeof(T));
        }

        public static T Average<T>(this IEnumerable<T> collection)
        {
            return (T)Convert.ChangeType(double.Parse(Sum(collection).ToString()) / collection.Count(), typeof(T));
        }

        #endregion

        public static Student[] FirstBeforeLast(Student[] students)
        {
            var result = students
                .Where(st => st.FirstName.CompareTo(st.LastName) < 0)
                .Select(x => x)
                .ToArray();
            return result;
        }

        public static Student[] AgeRange(Student[] students, int start, int end)
        {
            var result = students
                .Where(x => x.Age >= start && x.Age <= end)
                .Select(x => x)
                .ToArray();
            return result;
        }

        //public static Student[] AgeRange(Student[] students, int start, int end)
        //{
        //    var result = students
        //        .Where(x => x.Age >= start && x.Age <= end)
        //        .Select(x => x)
        //        .ToArray();
        //    return result;
        //}
    }
}
