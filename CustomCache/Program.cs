IDataDownloader dataDownloader = new CachingDataDownloader(
                                        new Cache<string, string>(),
                                        new SlowDataDownloader());

Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));
Console.WriteLine(dataDownloader.DownloadData("id3"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id3"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));

Console.ReadKey();

public interface IDataDownloader
{
    string DownloadData(string resourceId);
}

public class SlowDataDownloader : IDataDownloader
{
    public string DownloadData(string resourceId)
    {
        Thread.Sleep(1000);
        return $"Some data for {resourceId}";
    }
}

public class CachingDataDownloader(
                    Cache<string, string> cache, SlowDataDownloader dataDownloader
            ) : IDataDownloader
{
    private readonly Cache<string, string> _cache = cache;
    private readonly SlowDataDownloader _dataDownloader = dataDownloader;

    public string DownloadData(string resourceId)
    {
        if (_cache.Contains(resourceId))
        {
            return _cache.GetByKey(resourceId);
        }
        var result = _dataDownloader.DownloadData(resourceId);
        _cache.Store(resourceId, result);
        return result;
    }
}

public class Cache<Tkey, TValue> where Tkey : notnull
{
    private Dictionary<Tkey, TValue> _cache = [];

    public bool Contains(Tkey key) => _cache.ContainsKey(key);

    public void Store(Tkey key, TValue value) => _cache[key] = value;

    public TValue GetByKey(Tkey key) => _cache[key];

}