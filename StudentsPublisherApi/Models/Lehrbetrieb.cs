using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace StudentsPublisherApi.Models
{
    public class Lehrbetrieb
    {
        [JsonPropertyName("id_lehrbetrieb")]
        [BsonElement("_id")]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("firma")]
        [JsonPropertyName("firma")]
        [BsonIgnoreIfNull]
        public string? Firma { get; set; }

        [BsonElement("strasse")]
        [JsonPropertyName("strasse")]
        [BsonIgnoreIfNull]
        public string? Strasse { get; set; }

        [BsonElement("plz")]
        [JsonPropertyName("plz")]
        [BsonIgnoreIfNull]
        public string? plz { get; set; }

        [BsonElement("ort")]
        [JsonPropertyName("ort")]
        [BsonIgnoreIfNull]
        public string? ort { get; set; }
    }
}
