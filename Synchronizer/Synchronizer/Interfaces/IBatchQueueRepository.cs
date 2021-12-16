using Synchronizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synchronizer.Interfaces;

public interface IBatchQueueRepository<T>
{
    //public Task<Batch<Item<T>>> DeleteBatch(Batch<Item<T>> items, Item<T> item);
    //public Task<Batch<Item<T>>> ShowBatch(Batch<T> batch);
    public Task ConsumeBatch(Batch<T> batch);
    public Task RecoverBatch();
}
