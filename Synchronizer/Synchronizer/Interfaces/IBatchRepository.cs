using Synchronizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synchronizer.Interfaces
{
    public interface IBatchRepository<T>
    {
        public Task<Batch<T>> InsertItem(List<Item<T>> items);
        public Task<Batch<T>> UpdateItem(Item<T> item);
        public Task<Batch<T>> DeleteItem(Item<T> item);
        public Task<Item<T>> ShowItem(Item<T> item);
        public Task<Batch<T>> IndexItems();        
    }
}
