using MongoDB.Bson.Serialization.Attributes;

namespace Manipulative.api.service.Core.Entities
{
    public class ManipulativeEntity : Document
    {
        public string code { get; set; }

        public string name { get; set; }

        public string lastname { get; set; }
    }
}
