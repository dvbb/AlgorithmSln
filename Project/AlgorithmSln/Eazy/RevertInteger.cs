using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSln
{
    public class RevertInteger
    {
        //7. Reverse Integer [Easy]
        //Given a signed 32-bit integer x, return x with its digits reversed.
        //If reversing x causes the value to go outside the signed 32-bit integer range [-2^31, 2^31 - 1], then return 0.

        //input:  -123
        //output: -321
        public int Reverse(int x)
        {
            int result = 0;
            while (x != 0)
            {
                if (result > int.MaxValue / 10)
                {
                    return 0;
                }
                if (result < 0 && result*-1 > int.MaxValue / 10)
                {
                    return 0;
                }
                result = result * 10 + x % 10;
                x /= 10;
            }
            return result;
        }
    }
}
