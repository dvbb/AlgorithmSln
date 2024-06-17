using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTests.Huawei
{
    internal class HexadecimalToDecimal
    {
        [Test]
        [Ignore("need readline")]
        public void Test()
        {
            string line;
            while ((line = System.Console.ReadLine()) != null)
            { // 注意 while 处理多个 case
                string str = Convert.ToString(line).Replace("0x", "");
                int i = 0;
                int result = 0;
                while (i < str.Length)
                {
                    result = result * 10 + Parse(str[i]);
                    i++;
                }
            }
        }

        /// <summary>
        /// 写出一个程序，接受一个十六进制的数，输出该数值的十进制表示。
        /// 输入例子：0xAA
        /// 输出例子：170
        /// </summary>
        private void Solve()
        {
        }

        private static int Parse(char c)
        {
            switch (c)
            {
                case 'A':
                case 'a':
                    return 10;
                case 'B':
                case 'b':
                    return 11;
                case 'C':
                case 'c':
                    return 12;
                case 'D':
                case 'd':
                    return 13;
                case 'E':
                case 'e':
                    return 14;
                case 'F':
                case 'f':
                    return 15;
            }
            return int.Parse(c.ToString());
        }
    }
}
