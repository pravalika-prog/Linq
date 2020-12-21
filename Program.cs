using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            List<int> integerlist = new List<int>()
{
1,2,3,4,5,6,7,8
};
            var methodsyntax = (from obj in integerlist
                               where obj > 5
                               select obj).Sum();
            // var methodsyntax = integerlist.Where(obj => obj > 5);

           // foreach (var item in methodsyntax)
            //{
                Console.WriteLine(methodsyntax);
            
        }
    }
}
