using Synchronizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synchronizer.Interfaces;

public interface IBatchRepository<T>
{
    public Task<Batch<T>> Create(int id);

    public Task ConsumeItem(Batch<T> batch);
    public Task RecoverItem(Batch<T> batch);
}
