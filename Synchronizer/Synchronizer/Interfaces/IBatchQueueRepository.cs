using Synchronizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synchronizer.Interfaces;

public interface IBatchQueueRepository<T>
{
    public Task ConsumeBatch(Batch<T> batch);
    public Task RecoverBatch();
}
