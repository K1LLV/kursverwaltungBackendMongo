using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace StudentsPublisherApi.Models
{
    public class Kurs
    {
        [JsonPropertyName("id_kurs")]
        [BsonElement("_id")]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("kursnummer")]
        [JsonPropertyName("kursnummer")]
        [BsonIgnoreIfNull]
        public string? kursnummer { get; set; }

        [BsonElement("kursthema")]
        [JsonPropertyName("kursthema")]
        [BsonIgnoreIfNull]
        public string? kursthema { get; set; }

        [BsonElement("inhalt")]
        [JsonPropertyName("inhalt")]
        [BsonIgnoreIfNull]
        public string? inhalt { get; set; }

        [BsonElement("fk_id_dozent")]
        [JsonPropertyName("fk_id_dozent")]
        [BsonIgnoreIfNull]
        public string? fk_id_dozent { get; set; }

        [BsonElement("dauer")]
        [JsonPropertyName("dauer")]
        [BsonIgnoreIfNull]
        public string? Length { get; set; }

        [BsonElement("start")]
        [JsonPropertyName("start")]
        [BsonIgnoreIfNull]
        public DateTime? start { get; set; } = null!;

        [BsonElement("ende")]
        [JsonPropertyName("ende")]
        [BsonIgnoreIfNull]
        public DateTime? ende { get; set; } = null!;
    }
}
