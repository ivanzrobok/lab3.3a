using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlab3._3A
{
    public class BitString
    {
        public BitString() { }
        public BitString(long first, long second)
        {
            First = first;
            Second = second;
        }
        public BitString(BitString bit)
        {
            First = bit.First;
            Second = bit.Second;
        }
        public long First { get; set; }
        public long Second { get; set; }
        public static BitString operator --(BitString count) =>
            new BitString { First = count.First - 1, Second = count.Second - 1 };
        public static BitString operator ++(BitString count) =>
            new BitString { First = count.First + 1, Second = count.Second + 1 };
        public void Read()
        {
            Console.Write("Введіть перше число : ");
            string firstCount = Console.ReadLine();
            Console.Write("Введіть друге число : ");
            string secondCount = Console.ReadLine();
            if (Check(firstCount) && Check(secondCount))
            {
                First = long.Parse(firstCount);
                Second = long.Parse(secondCount);
            }
            else throw new Exception("Ви ввели неправильне число");
        }
        public virtual void Write()
        {
            Console.WriteLine($"Перше число {First}, друге число {Second}.");
        }
        private bool Check(string count)
        {
            return count.Length == count.Where(x => char.IsDigit(x)).Count();
        }
    }
    public class BitList : BitString
    {
        public BitList() : base() { }
        public BitList(long first, long second) : base(first, second) { }
        public BitList(BitString bit) : base(bit) { }
        public override void Write()
        {
            base.Write();
            Console.WriteLine($"Операція Not - {Not(this)}");
            Console.WriteLine($"Операція And - {And(this)}");
            Console.WriteLine($"Операція Or - {Or(this)}");
        }
        static public bool Not(BitString bit)
        {
            return bit.First != bit.Second;
        }
        static public bool And(BitString bit)
        {
            return IsNotZero(bit.First) && IsNotZero(bit.Second);
        }
        static public bool Or(BitString bit)
        {
            return IsNotZero(bit.First) || IsNotZero(bit.Second);
        }
        static private bool IsNotZero(long value)
        {
            return value != 0;
        }
    }
}
