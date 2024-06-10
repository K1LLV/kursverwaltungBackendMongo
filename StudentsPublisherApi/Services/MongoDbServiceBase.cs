using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using StudentsPublisherApi.Models;

namespace StudentsPublisherApi.Services
{
    public abstract class MongoDbServiceBase<TModel>
    {
        protected readonly IMongoCollection<TModel> _modelCollection;

        protected MongoDbServiceBase(IOptions<DatabaseSettings> dbSettings, string collectionName)
        {
            _modelCollection = new MongoClient(dbSettings.Value.ConnectionString)
                    .GetDatabase(dbSettings.Value.DatabaseName)
                    .GetCollection<TModel>(collectionName);
        }

        public async Task<IEnumerable<TModel>> GetAsync()
        {
            return await _modelCollection.Find(new BsonDocument()).ToListAsync();
        }

        public async Task<TModel> GetAsync(string id)
        {
            return await _modelCollection.Find(Builders<TModel>.Filter.Eq("Id", id)).FirstOrDefaultAsync();
        }

        public virtual async Task CreateAsync(TModel model)
        {
            await _modelCollection.InsertOneAsync(model);
        }

        public virtual async Task<UpdateResult> UpdateAsync(string id, TModel updatedStudentHistory)
        {
            return await _modelCollection.UpdateOneAsync(
                Builders<TModel>.Filter.Eq("Id", id),
                GetUpdateDefinition(updatedStudentHistory));
        }

        public virtual async Task DeleteAsync(string id)
        {
            await _modelCollection.DeleteOneAsync(Builders<TModel>.Filter.Eq("Id", id));
        }

        protected UpdateDefinition<T> GetUpdateDefinition<T>(T updatedModel)
        {
            var updateDefinitionBuilder = Builders<T>.Update;
            return updateDefinitionBuilder.Combine(GetUpdateDefinitions(updatedModel));
        }

        private IEnumerable<UpdateDefinition<T>> GetUpdateDefinitions<T>(T updatedModel)
        {
            var updateDefinitionBuilder = Builders<T>.Update;

            var properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                var value = property.GetValue(updatedModel);
                if (value != null)
                {
                    var updateDefinition = updateDefinitionBuilder.Set(property.Name, value);
                    yield return updateDefinition;
                }
            }
        }
    }
}
