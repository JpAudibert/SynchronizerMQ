using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synchronizer.Interfaces;

public interface IBatchQueueRepository
{
    public Task<Batch<Item<T>>> DeleteBatch(Batch<Item<T>> items, Item<T> item);
    public Task<Batch<Item<T>>> ShowBatch(Batch<T> batch);
}
