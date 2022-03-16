using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Operation_Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Management manage = new Management();

            List<ProductReview> ProductReviewLIst = new List<ProductReview>()

            {
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 1, Review = "good", IsLike = true },
                new ProductReview() { ProductId = 2, UserId = 2, Rating = 1, Review = "good", IsLike = true },
                new ProductReview() { ProductId = 3, UserId = 3, Rating = 1, Review = "good", IsLike = true },
                new ProductReview() { ProductId = 4, UserId = 4, Rating = 2, Review = "bad", IsLike = false },
                new ProductReview() { ProductId = 5, UserId = 5, Rating = 2, Review = "bad", IsLike = true },
                new ProductReview() { ProductId = 5, UserId = 6, Rating = 2, Review = "good", IsLike = false },
                new ProductReview() { ProductId = 7, UserId = 7, Rating = 3, Review = "bad", IsLike = true },
                new ProductReview() { ProductId = 7, UserId = 8, Rating = 3, Review = "good", IsLike = true },
                new ProductReview() { ProductId = 9, UserId = 9, Rating = 3, Review = "bad", IsLike = false },
                new ProductReview() { ProductId = 3, UserId = 15, Rating = 4, Review = "good", IsLike = false },
                new ProductReview() { ProductId = 3, UserId = 16, Rating = 4, Review = "nice", IsLike = true },
                new ProductReview() { ProductId = 10, UserId = 17, Rating = 4, Review = "bad", IsLike = true },
                new ProductReview() { ProductId = 10, UserId = 18, Rating = 5, Review = "good", IsLike = false },
                new ProductReview() { ProductId = 14, UserId = 19, Rating = 5, Review = "nice", IsLike = false },
                new ProductReview() { ProductId = 15, UserId = 28, Rating = 5, Review = "bad", IsLike = false },
                new ProductReview() { ProductId = 16, UserId = 21, Rating = 1, Review = "good", IsLike = true },
                new ProductReview() { ProductId = 18, UserId = 22, Rating = 1, Review = "good", IsLike = true },
                new ProductReview() { ProductId = 18, UserId = 23, Rating = 1, Review = "very bad", IsLike = false },
                new ProductReview() { ProductId = 19, UserId = 10, Rating = 2, Review = "bad", IsLike = true },
                new ProductReview() { ProductId = 20, UserId = 10, Rating = 3, Review = "good", IsLike = false },
                new ProductReview() { ProductId = 21, UserId = 11, Rating = 2, Review = "average", IsLike = true },
                new ProductReview() { ProductId = 21, UserId = 12, Rating = 3, Review = "bad", IsLike = false },
                new ProductReview() { ProductId = 25, UserId = 13, Rating = 3, Review = "good", IsLike = true },
                new ProductReview() { ProductId = 25, UserId = 14, Rating = 3, Review = "average", IsLike = true },
                new ProductReview() { ProductId = 25, UserId = 24, Rating = 4, Review = "average", IsLike = true },
            };
            //foreach (var list in ProductReviewLIst)
            //{
            //    Console.WriteLine("ProductId" + list.ProductId + "UserId" + list.UserId + "Rating"
            //        + list.Rating + "Review" + list.Review + "IsLike" + list.IsLike);
            //}

            bool flag = true; 
            while (flag)
            { 
                 Console.WriteLine("Welcome To LINQ_Operation_Demo Program");
                Console.WriteLine(" Enter options : " +
                        "\n 0. Exist"+
                        "\n 1. TopRecords" +
                        "\n 2. SelectToRecords " +
                        "\n 3. CountOfRecords" +
                        "\n 4. RetrieveProductIdCount" +
                        "\n 5. RetrieveProductIdAndReview"
                        );
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        flag = false;
                        break;

                    case 1:
                        manage.TopRecords(ProductReviewLIst);
                        break;
                    case 2:
                        manage.SelectToRecords(ProductReviewLIst);
                        break;
                    case 3:
                        manage.CountOfRecords(ProductReviewLIst);
                        break;
                    case 4:
                        manage.RetrieveProductIdCount(ProductReviewLIst);
                        break;
                    case 5:
                        manage.RetrieveProductIdAndReview(ProductReviewLIst);
                        break;

                }
            }
        }
    }
}
