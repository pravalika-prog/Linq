using System;
using System.Collections.Generic;

namespace Example5
{
    public class Product
    {
        public int ProducID { get; set; }
        public int UserID { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
        public static List<Product> Productlist()
        {
            List<Product>top = new List<Product>()
            {
                new Product() { ProducID = 1, UserID = 1, Rating = 2, Review = "Good" },
                new Product() { ProducID = 1, UserID = 1, Rating = 4, Review = "Good" },
                new Product() { ProducID = 1, UserID = 1, Rating = 5, Review = "Good" },
                new Product() { ProducID = 1, UserID = 1, Rating = 6, Review = "Good" },
                new Product() { ProducID = 2, UserID = 1, Rating = 2, Review = "nice" },
                new Product() { ProducID = 2, UserID = 1, Rating = 1, Review = "bas" },
                new Product() { ProducID = 2, UserID = 1, Rating = 1, Review = "Good" },
                new Product() { ProducID = 2, UserID = 1, Rating = 9, Review = "nice" },
                new Product() { ProducID = 2, UserID = 1, Rating = 10, Review = "nice" },
                new Product() { ProducID = 3, UserID = 1, Rating = 8, Review = "nice" },
                new Product() { ProducID = 3, UserID = 1, Rating = 3, Review = "nice" }
                // public bool isLike { get; set; }
            };
             return top;
        }
    }
}
