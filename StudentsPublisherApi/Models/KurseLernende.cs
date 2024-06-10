using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace StudentsPublisherApi.Models
{
    public class KurseLernende
    {
        [JsonPropertyName("id_kurs_lernende")]
        [BsonElement("_id")]
        [BsonIgnoreIfNull]
        public string? Id { get; set; }

        [BsonElement("fk_id_kurs")]
        [JsonPropertyName("fk_id_kurs")]
        [BsonIgnoreIfNull]
        public string? fk_id_kurs { get; set; }

        [BsonElement("fk_id_lernende")]
        [JsonPropertyName("fk_id_lernende")]
        [BsonIgnoreIfNull]
        public string? fk_id_lernende { get; set; }

        [BsonElement("note")]
        [JsonPropertyName("note")]
        [BsonIgnoreIfNull]
        public double? note { get; set; }
    }
}
