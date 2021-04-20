using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlab3._3A
{
    

    class Program
    {
        static void Main(string[] args)
        {
            BitList bit1 = new BitList();
            BitList bit2 = new BitList();
            while(true)
            {
                Console.WriteLine("first count");
                bit1.Read();
                Console.WriteLine(BitList.And(bit1));
                Console.WriteLine(BitList.Not(bit1));
                Console.WriteLine(BitList.Or(bit1));

                Console.WriteLine("second count");
                bit2.Read();
                Console.WriteLine(BitList.And(bit2));
                Console.WriteLine(BitList.Not(bit2));
                Console.WriteLine(BitList.Or(bit2));
             
                Console.Write("bit1==bit2 : ");
                Console.WriteLine(bit1 == bit2);

                Console.Write("bit1!=bit2 : ");
                Console.WriteLine(bit1 != bit2);
               
            }
        }
    }
}
