using StudentsPublisherApi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace StudentsPublisherApi.Services
{
    public class LehrbetriebService : MongoDbServiceBase<Lehrbetrieb>
    {
        public LehrbetriebService(IOptions<DatabaseSettings> dbSettings)
            : base(dbSettings, dbSettings.Value.Lehrbetriebe) { }
    }
}
