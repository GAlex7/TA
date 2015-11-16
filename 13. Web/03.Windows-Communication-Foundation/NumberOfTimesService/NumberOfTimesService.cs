namespace NumberOfTimesService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.Text;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class NumberOfTimesService : INumberOfTimesService
    {
        public int GetCounts(string text, string strToFind)
        {
            var result = 0;
            var txtLen = text.Length;
            var strLen = strToFind.Length;

            if (strLen > txtLen)
            {
                return result;
            }

            for (int i = 0; i < txtLen - strLen + 1; i++)
            {
                if (strToFind == text.Substring(i, strLen))
                {
                    result++;
                }
            }

            return result;
        }
    }
}
