using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmTests.Huawei
{
    internal class RandomNumber
    {
        [Test]
        [Ignore("need readline")]
        public void Test()
        {
            HashSet<int> ints = new HashSet<int>();
            int i = 0;
            string line;
            while ((line = System.Console.ReadLine()) != null)
            { // 注意 while 处理多个 case
                if (i == 0)
                {
                    i++;
                    continue;
                }
                int num = int.Parse(line);
                if (ints.Contains(num))
                {
                    continue;
                }
                ints.Add(num);
            }
            var nums = ints.ToList();
            nums.Sort();
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// 明明生成了N个1到500之间的随机整数。
        /// 请你删去其中重复的数字，即相同的数字只保留一个，把其余相同的数去掉，
        /// 然后再把这些数从小到大排序，按照排好的顺序输出。
        /// </summary>
        private void Solve(string line)
        {

        }
    }
}
