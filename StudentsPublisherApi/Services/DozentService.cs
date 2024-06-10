using StudentsPublisherApi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace StudentsPublisherApi.Services
{
    public class DozentService : MongoDbServiceBase<Dozent>
    {
        public DozentService(IOptions<DatabaseSettings> dbSettings)
            : base(dbSettings, dbSettings.Value.Dozenten) { }
    }
}
