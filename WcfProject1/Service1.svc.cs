using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfProject1
{
    public class Service1 : IService1
    {
        public int C2f(int c)
        {
            int f = (c * 9 / 5) + 32;
            return f;
        }

        public int F2c(int f)
        {
            int c = (f - 32) * 5 / 9;
            return c;
        }

        public string sortNums(string nums)
        {
            string[] numStrings = nums.Split(',');
            List<int> numbers = new List<int>();

            foreach (string numString in numStrings)
            {
                if (int.TryParse(numString, out int num))
                {
                    numbers.Add(num);
                }
            }

            numbers.Sort();
            string[] sortedNumStrings = numbers.Select(n => n.ToString()).ToArray();
            string sortedResult = string.Join(",", sortedNumStrings);

            return sortedResult;
        }

        public string encrypt(string text)
        {
            WcfProject1.Cryption encrypt = new WcfProject1.Cryption();
            return encrypt.encrypt(text);
        }

        public string decrypt(string text)
        {
            WcfProject1.Cryption decrypt = new WcfProject1.Cryption();
            return decrypt.decrypt(text);
        }
    }
}
