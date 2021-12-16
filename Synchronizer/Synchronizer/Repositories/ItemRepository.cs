using Synchronizer.Interfaces;
using Synchronizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synchronizer.Repositories;

public class ItemRepository: IItemRepository<string>
{
    private Batch<string> _batch;

    public ItemRepository(Batch<string> batch)
    {
        _batch = batch;
    }

    public async Task DeleteItem(Item<string> item)
    {
        try
        {
            if (item == null)
            {
                throw new ArgumentNullException("Item list is null");
            }

            // workaround
            _batch.Items = new LinkedList<Item<string>>(_batch.Items.Where(items => items.Id != item.Id));

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

    public async Task InsertItem(Item<string> item)
    {
        try
        {
            if (item == null)
            {
                throw new ArgumentNullException("Item list is null");
            }

            _batch.Items.AddLast(new Item<string>(item));

        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task<Item<string>?> ShowItem(Item<string> item)
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

    public async Task UpdateItem(Item<string> item)
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

        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task<Item<string>> Create(int id, string itemToSynchronize)
    {
        return new Item<string>(id, itemToSynchronize);
    }
}
