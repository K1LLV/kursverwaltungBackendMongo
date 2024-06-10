namespace StudentsPublisherApi.Models
{
    public class DatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string Lernende { get; set; } = null!;

        public string Dozenten { get; set; } = null!;

        public string Laender { get; set; } = null!;

        public string Lehrbetriebe { get; set; } = null!;

        public string LehrbetriebLernende { get; set; } = null!;

        public string Kurse { get; set; } = null!;

        public string KurseLernende { get; set; } = null!;
    }
}
