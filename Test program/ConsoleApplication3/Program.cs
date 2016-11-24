using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{

    class MaximalProduct
    {
      public MaximalProduct() { }

      public long maximalProduct (int sum, int num)
        {
            string strNum = "";
            int cycles = sum / num;
            var k = (double)sum / num - cycles;

            int last_index =(int) Math.Round(k*num, MidpointRounding.AwayFromZero) - 1;
            int local_mul = 1;

            for(int i = 0; i < num; i++)
            {
                if (i <= last_index)
                {
                    local_mul *= cycles + 1;
                    strNum += cycles + 1 + ",";
                }
                else { local_mul *= cycles;
                        strNum += cycles + ",";
                }
            }
            Console.WriteLine( "{0}   ", strNum);
            return local_mul;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            long result;

            MaximalProduct maxProduct = new MaximalProduct();
            result = maxProduct.maximalProduct(10,3);

            Console.WriteLine("You have digit is {0}", result);
            Console.ReadKey();
        }

    }
}
