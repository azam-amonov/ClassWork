namespace Dars_37_C30.Practic;

public class GenericCrud<T> where T : IEntity
{
    private List<T> _list;

    public GenericCrud()
    {
        _list = new List<T>();
    }

    public void Add(T item)
    {
        _list.Add(item);
    }

    public T Get(int id)
    {
        var obj = _list.FirstOrDefault(item => item.Id == id);
        if (obj is null)
            throw new ArgumentException("Object not found!");

        return obj;
    }

    public T Update(T obj)
    {
        var existItem = _list.FirstOrDefault(item => item.Id == obj.Id);

        if (existItem is null)
            throw new ArgumentException("Object not found!");

        existItem.Id = obj.Id;
        existItem.Name = obj.Name;
        existItem.UpdatedDateTime = DateTime.Now;

        return existItem;
    }

    public bool Delete(T obj)
    {
        var existItem = _list.FirstOrDefault(item => item.Id == obj.Id);
        if (existItem is null)
            return false;

        _list.Remove(existItem);

        return true;
    }

    public void GetAll()
    {
        if(_list.Count == 0)
            throw new ArgumentException("List is empty!");
        foreach (var item in _list)
        {
            Console.WriteLine($"{item.Id} {item.Name} {item.CreatedDateTime} {item.UpdatedDateTime}");
        }
    }

}