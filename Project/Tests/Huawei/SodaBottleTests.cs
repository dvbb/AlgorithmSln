using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTests.Huawei
{
    internal class SodaBottleTests
    {
        [Test]
        public void Test()
        {
            Console.WriteLine();
            Assert.AreEqual(1, Solve(3));
            Assert.AreEqual(5, Solve(10));
            Assert.AreEqual(40, Solve(81));
            Assert.AreEqual(0, Solve(0));
        }

        /// <summary>
        /// 某商店规定：三个空汽水瓶可以换一瓶汽水，允许向老板借空汽水瓶（但是必须要归还）。
        /// 小张手上有n个空汽水瓶，她想知道自己最多可以喝到多少瓶汽水。
        ///
        /// 输入：
        /// 输入文件最多包含 10 组测试数据，每个数据占一行，仅包含一个正整数 n（ 1<=n<=100 ），表示小张手上的空汽水瓶数。
        /// n=0 表示输入结束，你的程序不应当处理这一行
        ///
        /// 输出：
        /// 对于每组测试数据，输出一行，表示最多可以喝的汽水瓶数。如果一瓶也喝不到，输出0。
        /// </summary>
        private static int Solve(int total)
        {
            if (total == 0)
            {
                return 0;
            }
            int result = total / 3;
            int empty = total / 3 + total % 3;
            while (empty >= 3)
            {
                result += empty / 3;
                empty = empty / 3 + empty % 3;
            }
            if (empty == 2)
            {
                return result + 1;
            }
            return result;
        }
    }
}
