using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Manipulative.api.service.Core.Entities
{
    public class manipulative
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("code")]
        public string code { get; set; }

        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("lastname")]
        public string lastname { get; set; }
    }
}
