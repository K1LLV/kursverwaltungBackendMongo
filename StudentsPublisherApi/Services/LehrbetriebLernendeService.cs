using StudentsPublisherApi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace StudentsPublisherApi.Services
{
    public class LehrbetriebLernendeService : MongoDbServiceBase<LehrbetriebLernende>
    {
        public LehrbetriebLernendeService(IOptions<DatabaseSettings> dbSettings)
            : base(dbSettings, dbSettings.Value.LehrbetriebLernende) { }
    }
}
