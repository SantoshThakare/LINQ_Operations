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
        public void TopRecords(List<ProductReview> listproductReviews)
        {
            var recordeddata = (from productReview in listproductReviews
                                orderby productReview.Rating descending
                                select productReview).Take(3);

            foreach (var list in recordeddata)
            {
                Console.WriteLine("ProductId" + list.ProductId + "UserId" + list.UserId + "Rating"
                    + list.Rating + "Review" + list.Review + "IsLike" + list.IsLike);
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
                Console.WriteLine(list.ProductId + "   " + list.Count);
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

        public void RetrieveProductIdAndReview(List<ProductReview> listproductReviews)
        {
            var productList = listproductReviews.Select(p => new { productId = p.ProductId, review = p.Review }).ToList();
            foreach (var product in productList)
            {
                Console.WriteLine($"Product Id : {product.productId},  Product Reviews : {product.review}");
            }
        }
        public void SkipTopFiveRecords(List<ProductReview> listproductReviews)
        {
            var result = (from ProductReview
                         in listproductReviews
                          select ProductReview).Skip(5);

            Console.WriteLine("\n - - -  Displaying top 5 skipped records - - - ");
            Console.WriteLine(" ProductId\tUserId Rating\tReview \t IsLike ");
            foreach (ProductReview productReview in result)
            {
                Console.WriteLine(" {0}\t\t{1}\t{2}\t{3}\t  {4}", productReview.ProductId, productReview.UserId, productReview.Rating, productReview.Review, productReview.IsLike);
            }
        }
        public void RetrieveProductIdAndRetrieveBySelect(List<ProductReview> listproductReviews)
        {
            var productList = from p in listproductReviews select p;
            Console.WriteLine("\nPrinting Product Id and Product Review records by using select");
            foreach (var product in productList)
                Console.WriteLine($"Product Id: {product.ProductId},  Product Reviews: {product.Review}");

        }
        public DataTable CreateDataTableAndAddValues(List<ProductReview> listproductReviews)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ProductId", typeof(int));
            dataTable.Columns.Add("UserId", typeof(int));
            dataTable.Columns.Add("Rating", typeof(double));
            dataTable.Columns.Add("Review", typeof(string));
            dataTable.Columns.Add("IsLike", typeof(bool));
            DisplayProducts(dataTable);

            foreach (var data in listproductReviews)
            {
                dataTable.Rows.Add(data.ProductId, data.UserId, data.Rating, data.Review, data.IsLike);
            }
            Console.WriteLine("Successfully added values to datatable \n");
            return dataTable;
        }
        public void DisplayProducts(DataTable table)
        {
            var productId = from Products in table.AsEnumerable() select Products.Field<string>("ProductId");
            foreach (var product in productId)
            {
                Console.WriteLine(product);
            }


        }
        public void IsLikeValue(List<ProductReview> listproductReviews)
        {

            var recorddata = from product in listproductReviews where (product.IsLike == true) select product;
            foreach (ProductReview item in recorddata)
            {
                Console.WriteLine(item.ProductId + " " + item.UserId + " " + item.Rating + " " + item.Review + " " + item.IsLike);
            }
        }

        public void RetrieveAverageOfRecord(List<ProductReview> listproductReviews)
        {
            var proids = (from product in listproductReviews select product.ProductId).Distinct();
            Console.WriteLine("Productid  AverageRating");
            foreach (var pppp in proids)
            {
                var recorddata = (from product in listproductReviews where product.ProductId == pppp select product).Average(x => x.Rating);
                Console.WriteLine(pppp + "           " + recorddata);
            }
        }
        public void ReteriveNiceReviewRecord(List<ProductReview> list)
        {
            var recorddata = from product in list where (product.Review == "nice") select product;
            foreach (ProductReview item in recorddata)
            {
                Console.WriteLine(item.ProductId + " " + item.UserId + " " + item.Rating + " " + item.Review + " " + item.IsLike);
            }
        }
        public void RetrieveRecordbyuserid(List<ProductReview> list)
        {
            var recorddata = from product in list where (product.UserId == 10) orderby product.Rating descending select product;
            foreach (ProductReview item in recorddata)
            {
                Console.WriteLine(item.ProductId + " " + item.UserId + " " + item.Rating + " " + item.Review + " " + item.IsLike);
            }

        }
    }
}
