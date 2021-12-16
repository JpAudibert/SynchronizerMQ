using Synchronizer.Helper;
using Synchronizer.Models;
using Synchronizer.Repositories;

// find the file to search and get the words
List<string> FILE = new List<string>() { "..", "..", "..", "ExternalFiles", "words.csv" };
List<string> words = FileReader.ReadFile(FileReader.CombineInputPaths(FILE));

// create a batch repository
BatchRepository batchRepository = new BatchRepository();

// create a batch
Batch<string> batch = await batchRepository.Create(1);

// create an item repo
ItemRepository itemRepository = new ItemRepository(batch);

// indicates that the program is running
Console.WriteLine("Running");

//populate the batch
int idProvider = 1;
words.ForEach(async (word) =>
{
    await itemRepository.InsertItem(await itemRepository.Create(idProvider, word));
    idProvider++;
});

// create an update item
Item<string> itemUpdate = await itemRepository.Create(12, "elephant");

// update the item
await itemRepository.UpdateItem(itemUpdate);

// show the item
Console.WriteLine(await itemRepository.ShowItem(itemUpdate));

// delete the updated item
await itemRepository.DeleteItem(itemUpdate);

// retrieve all the items
Batch<string> batchList = await itemRepository.IndexItems();

// list all the items of the batch
batchList.Items.ToList().ForEach(item => Console.WriteLine(item.ItemToSynchronize)); 




