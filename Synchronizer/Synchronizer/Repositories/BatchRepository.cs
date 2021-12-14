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
    private Batch<string> _batch;

    public BatchRepository(Batch<string> batch)
    {
        _batch = batch;
    }

    public Task<Batch<string>> DeleteItem(Item<string> item)
    {
        try
        {
            if (item == null)
            {
                throw new ArgumentNullException("Item list is null");
            }

            _batch.Items.
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task<Batch<string>> IndexItems()
    {
        try
        {
            return _batch;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task<Batch<string>> InsertItem(List<Item<string>> items)
    {
        try
        {
            if (items == null)
            {
                throw new ArgumentNullException("Item list is null");
            }

            items.ForEach(item => {
                _batch.Items.Enqueue(new Item<string>(item));
            });

            return _batch;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task<Item<string>> ShowItem(Item<string> item)
    {
        try
        {
            if (item == null)
            {
                throw new ArgumentNullException("Item is null");
            }

             return _batch.Items.Where(items => items.Id == item.Id).First();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task<Batch<string>> UpdateItem(Item<string> item)
    {
        try
        {
            if (item == null)
            {
                throw new ArgumentNullException("Item is null");
            }

            Item<string> itemUpdate = _batch.Items.Where(items => items.Id == item.Id).First();

            itemUpdate.Id = item.Id;
            itemUpdate.ItemToSynchronize = item.ItemToSynchronize;

            return _batch;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
