using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synchronizer.Models;

public class BatchQueue<T>
{
    public Queue<Batch<T>> SyncBatch { get; set; }

    public BatchQueue(Queue<Batch<T>> syncBatch)
    {
        SyncBatch = syncBatch;
    }
}
