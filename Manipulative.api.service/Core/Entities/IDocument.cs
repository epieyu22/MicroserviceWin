using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Manipulative.api.service.Core.Entities
{
    public interface IDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        ObjectId Id { get; set; }

        DateTime CreateDate { get; }
    }
}
