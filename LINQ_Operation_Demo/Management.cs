using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Operation_Demo
{  
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();
        public void  TopRecords(List<ProductReview>listproductReviews)
          {
            var recordeddata = (from productReview in listproductReviews
                                orderby productReview.Rating descending
                                select productReview).Take(3);
             
            foreach (var list in recordeddata)
            {
                Console.WriteLine("ProductId" + list.ProductId + "UserId" + list.UserId + "Rating"
                    + list.Rating+ "Review" + list.Review + "IsLike" + list.IsLike);
            }

        } 
        public void SelectToRecords(List<ProductReview> listproductReviews)  
        {
            var recordeddata = from productReview in listproductReviews
                               where

                               (productReview.ProductId == 1 && productReview.Rating > 3) || 
                               (productReview.ProductId == 4 && productReview.Rating > 3) ||
                               (productReview.ProductId == 9 && productReview.Rating > 3)
                               select productReview;
            foreach (var list in recordeddata)
            {
                Console.WriteLine("ProductId" + list.ProductId + "UserId" + list.UserId + "Rating"
                    + list.Rating + "Review" + list.Review + "IsLike" + list.IsLike);
            }
        }
        public void CountOfRecords(List<ProductReview> listproductReviews)
        {
            var recordData = listproductReviews.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });
           
            foreach (var list in recordData)
            {
                Console.WriteLine( list.ProductId + "   "  + list.Count);
                Console.ReadLine();
            }
        }
        public void RetrieveProductIdCount(List<ProductReview> listproductReviews)
        {
            var resProductCount = listproductReviews.GroupBy(x => x.ProductId).Select(p => new { productId = p.Key, count = p.Count() });

            foreach (var list in resProductCount)
            {
                Console.WriteLine($"Product Id : {list.productId},  Product Count : {list.count}");

            }
        }

        public  void RetrieveProductIdAndReview(List<ProductReview> listproductReviews)
        {
            var productList = listproductReviews.Select(p => new { productId = p.ProductId, review = p.Review }).ToList();
            foreach (var product in productList)
            {
                Console.WriteLine($"Product Id : {product.productId},  Product Reviews : {product.review}");
            }
        }


    }
}
