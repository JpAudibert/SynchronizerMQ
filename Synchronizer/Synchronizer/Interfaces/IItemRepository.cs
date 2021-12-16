using Synchronizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synchronizer.Interfaces;

    public interface IItemRepository<T>
    {
        public Task<Item<T>> Create(int id, T itemToSynchronize);

        public Task InsertItem(Item<T> item);
        public Task UpdateItem(Item<T> item);
        public Task DeleteItem(Item<T> item);
        public Task<Item<T>> ShowItem(Item<T> item);
        public Task<Batch<T>> IndexItems();
    }
