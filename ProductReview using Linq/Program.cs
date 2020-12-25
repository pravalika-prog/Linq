using Example5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductReview
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("show the   productratings in descending order");
            //Console.WriteLine("-----------------------------------------------");
            var toprecords = Product.Productlist().OrderByDescending(x => x.Rating).ToList();
            // Console.WriteLine("show the   productratings in descending order");
            foreach (var list in toprecords)
            {
                Console.WriteLine("ProductID:- " + list.ProducID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review);
            }
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("show the   product depends on reviews");

            Console.WriteLine("-----------------------------------------------");
            IEnumerable<Product> QuerySyntax = from ptd in Product.Productlist()
                                               where ptd.Review == "Good"
                                               select ptd;
            foreach (var items in QuerySyntax)
            {
                Console.WriteLine("Review:{0},ProductID:{1}", items.Review, items.ProducID);
            }
            Console.WriteLine("show the   product depends on gruops");
            Console.WriteLine("-----------------------------------------------");
            var GroupByMS = Product.Productlist().GroupBy(s => s.ProducID);
            foreach (var group in GroupByMS)
            {
                Console.WriteLine(group.Key + " : " + group.Count());

                foreach (var item in group)
                {
                    Console.WriteLine("ProductID:- " + item.ProducID + " " + "UserID:- " + item.UserID
                         + " " + "Rating:- " + item.Rating + " " + "Review:- " + item.Review);
                }

            }
        }
    }
}

