using StudentsPublisherApi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace StudentsPublisherApi.Services
{
    public class StudentsService : MongoDbServiceBase<Student>
    {
        public StudentsService(IOptions<DatabaseSettings> dbSettings)
            : base(dbSettings, dbSettings.Value.Lernende) { }
    }
}
