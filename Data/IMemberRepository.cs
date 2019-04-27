using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;

namespace AzureCosmosDbExample.Data
{
    public interface IMemberRepository<T> where T : class
    {
        Task<Document> CreateMemberAsync(T member);
        Task<Document> UpdateMemberAsync(string Id, T member);
        Task<T> GetMemberAsync(string Id);
        Task<IEnumerable<T>> GetMembersAsync(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetMembersAsync();
        Task DeleteMember(string Id);
    }
}
