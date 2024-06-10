using StudentsPublisherApi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace StudentsPublisherApi.Services
{
    public class KurseLernendeService : MongoDbServiceBase<KurseLernende>
    {
        public KurseLernendeService(IOptions<DatabaseSettings> dbSettings)
            : base(dbSettings, dbSettings.Value.KurseLernende) { }
    }
}
