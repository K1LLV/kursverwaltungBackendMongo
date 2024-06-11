using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace StudentsPublisherApi.Models
{
    public class Land
    {
        [JsonPropertyName("id_land")]
        [BsonElement("_id")]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("land")]
        [JsonPropertyName("land")]
        [BsonIgnoreIfNull]
        public string? Vorname { get; set; }
    }
}
