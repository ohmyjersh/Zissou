using Microsoft.Extensions.Options;
using Raven.Client;
using Raven.Client.Document;

namespace zissou
{
    public class DocumentStoreHolder : IDocumentStoreHolder
    {
        public DocumentStoreHolder(IOptions<RavenSettings> ravenSettings)
        {
            var settings = ravenSettings.Value;

            Store = new DocumentStore
            {
                Url = settings.Url,
                DefaultDatabase = settings.DefaultDatabase
            }.Initialize();
        }

        public IDocumentStore Store { get; }
    }

    public interface IDocumentStoreHolder
    {
        IDocumentStore Store { get; }
    }
}