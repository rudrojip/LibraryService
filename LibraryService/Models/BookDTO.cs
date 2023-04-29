using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace LibraryService.Models
{
    public class BookDTO
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("author")]
        public string? Author { get; set; }
        [BsonElement("country")]
        public string? Country { get; set; }
        [BsonElement("imageLink")]
        public string? ImageLink { get; set; }
        [BsonElement("language")]
        public string? Language { get; set; }
        [BsonElement("link")]
        public string? Link { get; set; }
        [BsonElement("pages")]
        public int Pages { get; set; }
        [BsonElement("title")]
        public string? Title { get; set; }
        [BsonElement("year")]
        public int Year { get; set; }
        [BsonElement("stockLeft")]
        public int StockLeft { get; set; }
        [BsonElement("price")]
        public int Price { get; set; }

    }
}
