using System;

namespace Algorithms
{
    internal static class Program
    {
        public static void Main()
        {
            Hashtable hashtable = new Hashtable();
            var value = hashtable.Get("Faridun");
            Console.WriteLine(value);
            
            hashtable.Put("Faridun", "Berdiev");
            value = hashtable.Get("Faridun");
            Console.WriteLine(value);
        }
    }
}