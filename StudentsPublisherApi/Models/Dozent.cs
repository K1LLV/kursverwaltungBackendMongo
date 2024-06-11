using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace StudentsPublisherApi.Models
{
    public class Dozent
    {
        [JsonPropertyName("id_dozent")]
        [BsonElement("_id")]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("vorname")]
        [JsonPropertyName("vorname")]
        [BsonIgnoreIfNull]
        public string? Vorname { get; set; }

        [BsonElement("nachname")]
        [JsonPropertyName("nachname")]
        [BsonIgnoreIfNull]
        public string? Nachname { get; set; }

        [BsonElement("strasse")]
        [JsonPropertyName("strasse")]
        [BsonIgnoreIfNull]
        public string? Strasse { get; set; }

        [BsonElement("plz")]
        [JsonPropertyName("plz")]
        [BsonIgnoreIfNull]
        public string? Plz { get; set; }

        [BsonElement("ort")]
        [JsonPropertyName("ort")]
        [BsonIgnoreIfNull]
        public string? Ort { get; set; }

        [BsonElement("birthdate")]
        [JsonPropertyName("geburtsdatum")]
        [BsonIgnoreIfNull]
        public DateTime? Birthdate { get; set; } = null!;

        [BsonElement("fk_id_land")]
        [JsonPropertyName("fk_id_land")]
        [BsonIgnoreIfNull]
        public string? Fk_id_land { get; set; }

        [BsonElement("geschlecht")]
        [JsonPropertyName("geschlecht")]
        [BsonIgnoreIfNull]
        public string? Geschlecht { get; set; }

        [BsonElement("telefon")]
        [JsonPropertyName("telefon")]
        [BsonIgnoreIfNull]
        public string? Telefon { get; set; }

        [BsonElement("handy")]
        [JsonPropertyName("handy")]
        [BsonIgnoreIfNull]
        public string? Handy { get; set; }

        [BsonElement("email")]
        [JsonPropertyName("email")]
        [BsonIgnoreIfNull]
        public string? Email { get; set; }
    }
}
