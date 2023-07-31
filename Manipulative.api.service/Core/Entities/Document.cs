using MongoDB.Bson;
using System;

namespace Manipulative.api.service.Core.Entities
{
    public class Document : IDocument
    {
        public ObjectId Id { get; set; }

        public DateTime CreateDate => Id.CreationTime;
    }
}
