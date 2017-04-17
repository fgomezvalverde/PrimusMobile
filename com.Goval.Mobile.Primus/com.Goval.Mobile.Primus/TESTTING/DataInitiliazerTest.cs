using com.Goval.Mobile.Primus.Core.Amazon;
using com.Goval.Mobile.Primus.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.Goval.Mobile.Primus.TESTTING
{
    public class DataInitiliazerTest
    {
        public static void AddWeeklyListObjects()
        {

            var list = new List<Post>
            {
                new Post{Id = Guid.NewGuid().ToString(),Media_Path = "https://s3.amazonaws.com/goval.primus/MobilePhotos/WeeklyPosts/320/weeklyPostTest.jpg",Name = Guid.NewGuid().ToString() },
                new Post{Id = Guid.NewGuid().ToString(),Media_Path = "https://s3.amazonaws.com/goval.primus/MobilePhotos/WeeklyPosts/320/weeklyPostTest.jpg",Name = Guid.NewGuid().ToString() },
                new Post{Id = Guid.NewGuid().ToString(),Media_Path = "https://s3.amazonaws.com/goval.primus/MobilePhotos/WeeklyPosts/320/weeklyPostTest.jpg",Name = Guid.NewGuid().ToString() },
                new Post{Id = Guid.NewGuid().ToString(),Media_Path = "https://s3.amazonaws.com/goval.primus/MobilePhotos/WeeklyPosts/320/weeklyPostTest.jpg",Name = Guid.NewGuid().ToString() }
            };

            foreach (var item in list)
            {
                DynamoDBManager.GetInstance().SaveAsync<Post>(item);
            }
        }


        public static void AddCategoriesObjects()
        {

            var list = new List<Post>
            {
                new Post{Id = Guid.NewGuid().ToString(),Media_Path = "https://s3.amazonaws.com/goval.primus/MobilePhotos/Categories/320/paisaje.jpg",Name = Guid.NewGuid().ToString() },
                new Post{Id = Guid.NewGuid().ToString(),Media_Path = "https://s3.amazonaws.com/goval.primus/MobilePhotos/Categories/320/paisaje.jpg",Name = Guid.NewGuid().ToString() },
                new Post{Id = Guid.NewGuid().ToString(),Media_Path = "https://s3.amazonaws.com/goval.primus/MobilePhotos/Categories/320/paisaje.jpg",Name = Guid.NewGuid().ToString() },
                new Post{Id = Guid.NewGuid().ToString(),Media_Path = "https://s3.amazonaws.com/goval.primus/MobilePhotos/Categories/320/paisaje.jpg",Name = Guid.NewGuid().ToString() }
            };

            var categoryList = new List<Category>
            {
                new Category{Id = Guid.NewGuid().ToString(),Category_Name = "RESTAURANTS", Media_Path = "https://s3.amazonaws.com/goval.primus/MobilePhotos/WeeklyPosts/320/weeklyPostTest.jpg",Category_Posts = list },
                new Category{Id = Guid.NewGuid().ToString(),Category_Name = "BARS", Media_Path = "https://s3.amazonaws.com/goval.primus/MobilePhotos/WeeklyPosts/320/weeklyPostTest.jpg",Category_Posts = list },
                new Category{Id = Guid.NewGuid().ToString(),Category_Name = "CLUBS", Media_Path = "https://s3.amazonaws.com/goval.primus/MobilePhotos/WeeklyPosts/320/weeklyPostTest.jpg",Category_Posts = list },
                new Category{Id = Guid.NewGuid().ToString(),Category_Name = "EXHIBITIONS", Media_Path = "https://s3.amazonaws.com/goval.primus/MobilePhotos/WeeklyPosts/320/weeklyPostTest.jpg",Category_Posts = list },
                new Category{Id = Guid.NewGuid().ToString(),Category_Name = "THEATRE", Media_Path = "https://s3.amazonaws.com/goval.primus/MobilePhotos/WeeklyPosts/320/weeklyPostTest.jpg",Category_Posts = list },
                new Category{Id = Guid.NewGuid().ToString(),Category_Name = "LIFE MUSIC", Media_Path = "https://s3.amazonaws.com/goval.primus/MobilePhotos/WeeklyPosts/320/weeklyPostTest.jpg",Category_Posts = list }
            };

            foreach (var item in categoryList)
            {
                DynamoDBManager.GetInstance().SaveAsync<Category>(item);
            }
        }

    }
}
