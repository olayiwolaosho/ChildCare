using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewDemo.Services
{
    public interface IDatastore<T>
    {
        Task<bool> AddItemAsync(T item);
        Task<bool> UpdateItemAsync(T item);
        Task<bool> DeleteItemAsync(string id);
        Task<T> GettItemAsync(string id);
        Task<IEnumerable<T>> GettItemsAsync();
    }
}
