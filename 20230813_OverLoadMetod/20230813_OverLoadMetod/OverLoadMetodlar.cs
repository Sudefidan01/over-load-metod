using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230813_OverLoadMetod
{
    internal class OverLoadMetodlar
    {
        public void Topla(int s1,int s2)
        {
            Console.WriteLine(s1+s2);
        }
        public void Topla(double s1,double s2) 
        {
            Console.WriteLine(s1+s2);
        }

        public void Topla(int s1,int s2,int s3) 
        {
            Console.WriteLine(s1+s2+s3);
        }
        public void Topla(double s1,double s2,double s3)
        {
            Console.WriteLine(s1+s2+s3);
        }
    }
}
