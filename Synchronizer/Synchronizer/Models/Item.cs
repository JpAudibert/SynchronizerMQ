using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synchronizer.Models;

public class Item<T>
{
    public int Id { get; set; }
    public T ItemToSynchronize { get; set; }

    public Item(int id, T itemToSynchronize)
    {
        Id = id;
        ItemToSynchronize = itemToSynchronize;
    }

    public Item(Item<T> item)
    {
        Id = item.Id;
        ItemToSynchronize = item.ItemToSynchronize;
    }
}
