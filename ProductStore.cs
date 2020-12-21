using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace linq
{

    class ProductStore
    {
        public string productName { get; set; }
        public int productPrice { get; set; }
    }

    class Program3
    {
        static void Main(string[] args)
        {
            // Creating List
            IList<ProductStore> productList = new List<ProductStore>();

            productList.Add(new ProductStore { productName = "Hard Disk", productPrice = 1280 });
            productList.Add(new ProductStore { productName = "Monitor", productPrice = 3000 });
            productList.Add(new ProductStore { productName = "Monitor", productPrice = 3500 });
            productList.Add(new ProductStore { productName = "Monitor", productPrice = 2000 });
            productList.Add(new ProductStore { productName = "SSD Disk", productPrice = 3500 });
            productList.Add(new ProductStore { productName = "RAM", productPrice = 2450 });
            productList.Add(new ProductStore { productName = "Processor", productPrice = 7680 });
            productList.Add(new ProductStore { productName = "Bluetooth", productPrice = 540 });
            productList.Add(new ProductStore { productName = "Keyboard & Mouse", productPrice = 1130 });

          //  var result = productList.OrderBy(p => p.productName).ThenByDescending(p => p.productPrice);
          var result= productList.OrderBy(p => p.productPrice).Reverse();

            foreach (var list in result)
            {
                Console.WriteLine("Product Name: {0} | Product Price : {1}", list.productName, list.productPrice);
            }
        }
    }
}
