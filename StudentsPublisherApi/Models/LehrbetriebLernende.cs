using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace StudentsPublisherApi.Models
{
    public class LehrbetriebLernende
    {
        [JsonPropertyName("id_lehrbetrieb_lernende")]
        [BsonElement("_id")]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("fk_id_lehrbetrieb")]
        [JsonPropertyName("fk_id_lehrbetrieb")]
        [BsonIgnoreIfNull]
        public string? fk_id_lehrbetrieb { get; set; }

        [BsonElement("fk_id_lernende")]
        [JsonPropertyName("fk_id_lernende")]
        [BsonIgnoreIfNull]
        public string? fk_id_lernende { get; set; }

        [BsonElement("beruf")]
        [JsonPropertyName("beruf")]
        [BsonIgnoreIfNull]
        public string? beruf { get; set; }

        [BsonElement("start")]
        [JsonPropertyName("start")]
        [BsonIgnoreIfNull]
        public DateTime? start { get; set; } = null;

        [BsonElement("ende")]
        [JsonPropertyName("ende")]
        [BsonIgnoreIfNull]
        public DateTime? ende { get; set; } = null;
    }
}
