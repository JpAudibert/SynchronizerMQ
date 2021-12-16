using Synchronizer.Interfaces;
using Synchronizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synchronizer.Repositories;

public class BatchRepository : IBatchRepository<string>
{
    public Task ConsumeItem(Batch<string> batch)
    {
        throw new NotImplementedException();
    }

    public Task RecoverItem()
    {
        throw new NotImplementedException();
    }

    public async Task<Batch<string>> Create(int id)
    {
        return new Batch<string>(id);
    }
}
