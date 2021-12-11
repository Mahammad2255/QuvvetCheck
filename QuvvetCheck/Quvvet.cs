using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuvvetCheck
{
    class Quvvet
    {
        public void Check(int n)
        {
            int quvvet = 2;
            while(n%quvvet == 0)
            {
                n = n / quvvet;
            }

            if(n == 1)
            {
                Console.WriteLine("Quvvetidir");
            }
            else
            {
                Console.WriteLine("Quvveti deyil");
            }
        }
    }
}
