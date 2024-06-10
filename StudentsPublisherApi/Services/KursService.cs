using StudentsPublisherApi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace StudentsPublisherApi.Services
{
    public class KursService : MongoDbServiceBase<Kurs>
    {
        public KursService(IOptions<DatabaseSettings> dbSettings)
            : base(dbSettings, dbSettings.Value.Kurse) { }
    }
}
