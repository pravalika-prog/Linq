using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linq
{
    class productwhere
    {
        static void Main(string[] args)
        {
            IList<string> productList = new List<string>()
            {
                "Hard Disk",
                "Monitor",
                "SSD Disk",
                "RAM",
                "Processor",
                "Bluetooth",
                "Keyboard & Mouse"
            };

            var result = productList.Where(p => p.Contains("Disk"));

            foreach (string str in result)
            {
                Console.WriteLine(str.ToString());
            }

        }
    }
}