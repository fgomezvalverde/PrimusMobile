using Amazon.DynamoDBv2.DataModel;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.Goval.Mobile.Primus.Model
{
    [DynamoDBTable("Post")]
    [ImplementPropertyChanged]
    public class Post

    {
        [DynamoDBHashKey]
        public string Id { get; set; }

        [DynamoDBProperty]
        public string Name { get; set; }

        [DynamoDBProperty]
        public string Media_Path { get; set; }

        [DynamoDBProperty]
        public string Description { get; set; }

        [DynamoDBProperty]
        public string Header { get; set; }

        [DynamoDBProperty]
        public DateTime Date { get; set; }

    }
}
