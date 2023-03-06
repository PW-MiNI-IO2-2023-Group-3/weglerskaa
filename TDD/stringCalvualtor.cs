using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class stringCalvualtor
    {
        public static int SumString(string str)
        {
            if (str == string.Empty)
                return 0;

            int result=0;

            if (int.TryParse(str, out result))
            {
                if (result < 0) { throw new ArgumentException(); }
                return result;
            }
            string[] numbers;
            char sep;
            if(str.Substring(0,2) == "//")
            {
                sep = str[2];
                 numbers = str.Substring(4).Split('\n', ',',sep);
            }
            else
            {
                 numbers = str.Split('\n',',');
            }

            
            foreach (var number in numbers)
            {
                int num=int.Parse(number);
                if(num<0) { throw new ArgumentException(); }
                if (num > 1000) num = 0;
                result += num;

            }
               

            return result;
        }

    }
}
