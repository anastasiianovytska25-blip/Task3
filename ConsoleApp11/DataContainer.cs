
public class DataContainer<T> where T : DataItem
{
    private readonly List<T> _items = new();
    public void AddItem(T item)
    {
        _items.Add(item);
    }
    public long GetTotalSize()
    {
        long res = 0;
        foreach (var i in _items)
        {
            res += i.GetSize();
            
        }

        return res;
    }
}