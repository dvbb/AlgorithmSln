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
            int temp;
            int result = 0;
            if (x < 0)
            {
                temp = x * -1;
                while (temp*1.0 / 10 > 0)
                {
                    result = result * 10 + temp % 10;
                    temp = (temp - temp % 10) / 10;
                }
                return result * -1;
            }
            else
            {
                temp = x;
                while (temp * 1.0 / 10 > 0)
                {
                    result = result * 10 + temp % 10;
                    temp = (temp - temp % 10) / 10;
                }
                return result;
            }
        }
    }
}
