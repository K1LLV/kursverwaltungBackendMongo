using StudentsPublisherApi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace StudentsPublisherApi.Services
{
    public class LandService : MongoDbServiceBase<Land>
    {
        public LandService(IOptions<DatabaseSettings> dbSettings)
            : base(dbSettings, dbSettings.Value.Laender) { }
    }
}
