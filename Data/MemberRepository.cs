using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;

namespace AzureCosmosDbExample.Data
{
    public class MemberRepository<T> : IMemberRepository<T> where T : class
    {
        private readonly string Endpoint = "https://xyzxuz.documents.azure.com:443/";
        private readonly string Key = "XxxXXxyXxxyXyXyxyXXyyXXzZXxXZXzxXXXXXXXZZZXXZZXzXXxzxzyYxyxyyyxxZZXxxxXxxXxXxxXXX==";
        private readonly string DatabaseId = "MemberDB";
        private readonly string CollectionId = "Members";

        private DocumentClient client;

        public MemberRepository()
        {
            this.client = new DocumentClient(new Uri(Endpoint), Key);

            CreateDatabaseIfNotExistsAsync().Wait();
            CreateCollectionIfNotExistsAsync().Wait();
        }

        public async Task<Document> CreateMemberAsync(T member)
        {
            var result = await client.CreateDocumentAsync(UriFactory.CreateDocumentCollectionUri(DatabaseId, CollectionId), member);
            return result;
        }

        public async Task DeleteMember(string Id)
        {
            await client.DeleteDocumentAsync(UriFactory.CreateDocumentUri(DatabaseId, CollectionId, Id));
        }

        public async Task<T> GetMemberAsync(string Id)
        {
            Document document = await client.ReadDocumentAsync(UriFactory.CreateDocumentUri(DatabaseId, CollectionId, Id));
            return (T)(dynamic)document;
        }

        public async Task<IEnumerable<T>> GetMembersAsync(Expression<Func<T, bool>> predicate)
        {
            IDocumentQuery<T> query = client.CreateDocumentQuery<T>(
                UriFactory.CreateDocumentCollectionUri(DatabaseId, CollectionId),
                new FeedOptions { MaxItemCount = -1 }).Where(predicate).AsDocumentQuery();

            List<T> result = new List<T>();

            while (query.HasMoreResults)
            {
                result.AddRange(await query.ExecuteNextAsync<T>());
            }

            return result;
        }

        public async Task<IEnumerable<T>> GetMembersAsync()
        {
            IDocumentQuery<T> query = client.CreateDocumentQuery<T>(
              UriFactory.CreateDocumentCollectionUri(DatabaseId, CollectionId),
              new FeedOptions { MaxItemCount = -1 }).AsDocumentQuery();

            List<T> result = new List<T>();

            while (query.HasMoreResults)
            {
                result.AddRange(await query.ExecuteNextAsync<T>());
            }

            return result;
        }

        public async Task<Document> UpdateMemberAsync(string Id, T member)
        {
            var result = await client.ReplaceDocumentAsync(UriFactory.CreateDocumentUri(DatabaseId, CollectionId, Id), member);
            return result;
        }

        private async Task CreateDatabaseIfNotExistsAsync()
        {
            try
            {
                await client.ReadDatabaseAsync(UriFactory.CreateDatabaseUri(DatabaseId));
            }
            catch (DocumentClientException e)
            {
                if (e.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    await client.CreateDatabaseAsync(new Database { Id = DatabaseId });
                }
            }
        }

        private async Task CreateCollectionIfNotExistsAsync()
        {
            try
            {
                await client.ReadDocumentCollectionAsync(UriFactory.CreateDocumentCollectionUri(DatabaseId, CollectionId));
            }
            catch (Exception)
            {
                await client.CreateDocumentCollectionAsync(
                        UriFactory.CreateDatabaseUri(DatabaseId),
                        new DocumentCollection { Id = CollectionId },
                        new RequestOptions { OfferThroughput = 1000 });
            }

        }
    }
}
