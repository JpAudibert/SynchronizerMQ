using Synchronizer.Helper;
using Synchronizer.Models;
using Synchronizer.Repositories;

List<string> FILE = new List<string>() { "..", "..", "..", "ExternalFiles", "words.csv" };
List<string> words = FileReader.ReadFile(FileReader.CombineInputPaths(FILE));

BatchRepository batchRepository = new BatchRepository();

Batch<string> batch = await batchRepository.Create(1);

ItemRepository itemRepository = new ItemRepository(batch);

Console.WriteLine("Running");

int idProvider = 1;
words.ForEach(async (word) =>
{
    await itemRepository.InsertItem(await itemRepository.Create(idProvider, word));
    idProvider++;
});

Item<string> itemUpdate = await itemRepository.Create(12, "elephant");

await itemRepository.UpdateItem(itemUpdate);

Console.WriteLine(await itemRepository.ShowItem(itemUpdate));

await itemRepository.DeleteItem(itemUpdate);

Batch<string> batchList = await itemRepository.IndexItems();

batchList.Items.ToList().ForEach(item => Console.WriteLine(item.ItemToSynchronize)); 




