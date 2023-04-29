using LibraryService.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace LibraryService.Services
{


    public class BooksService
    {
        private readonly IMongoCollection<BookDTO> _booksCollection;

        public BooksService(
            IOptions<LibraryDatabaseSettings> LibraryDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                LibraryDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                LibraryDatabaseSettings.Value.DatabaseName);

            _booksCollection = mongoDatabase.GetCollection<BookDTO>(
                LibraryDatabaseSettings.Value.BooksCollectionName);
        }

        public async Task<List<BookDTO>> GetAsync() =>
            await _booksCollection.Find(_ => true).ToListAsync();

        public async Task<BookDTO?> GetAsync(string id) =>
            await _booksCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(BookDTO newBook) =>
            await _booksCollection.InsertOneAsync(newBook);

        public async Task UpdateAsync(string id, BookDTO updatedBook) =>
            await _booksCollection.ReplaceOneAsync(x => x.Id == id, updatedBook);

        public async Task RemoveAsync(string id) =>
            await _booksCollection.DeleteOneAsync(x => x.Id == id);

    }

}