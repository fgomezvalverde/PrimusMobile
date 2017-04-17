using Amazon.DynamoDBv2.DataModel;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.Goval.Mobile.Primus.Model
{
    [DynamoDBTable("Category")]
    [ImplementPropertyChanged]
    public class Category
    {
        [DynamoDBHashKey]
        public string Id { get; set; }

        [DynamoDBProperty]
        public string Category_Name { get; set; }

        [DynamoDBProperty]
        public string Media_Path { get; set; }

        [DynamoDBProperty]
        public List<Post> Category_Posts { get; set; }
    }
}
