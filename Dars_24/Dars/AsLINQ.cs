namespace Dars_24.Dars;
// concat - 2 ta to'plamni birlashtirish
// intersect - 2 ta to'plamning bir xil elementlarini olish
// except - 2 ta to'plamning farqi
// union - 2 ta to'plamning birlashmasi - faqat unique elementlarni olish

public interface ICollectionAggregate
{
    List<T> Concat<T>(in List<T>listA, in  List<T> listB);
    List<T> Intersect<T>(in List<T>listA, in List<T> listB);
    List<T> Except<T>(in List<T>listA, in List<T> listB);
    List<T> Union<T>(in List<T>listA, in List<T> listB);
}

public class CollectionAggregate : ICollectionAggregate
{
    public List<T> Concat<T>(in List<T> listA, in List<T> listB)
    {
        var newList = new List<T>();
        newList.AddRange(listA);
        newList.AddRange(listB);
        
        return newList;
    }

    public List<T> Intersect<T>(in List<T> listA, in List<T> listB)
    {
        var list = new List<T>();
        foreach (var itemA in listA)
            if (listB.Contains(itemA))
                list.Add(itemA);

        return list;
    }

    public List<T> Except<T>(in List<T> listA, in List<T> listB)
    {
        var list = new List<T>();
        foreach (var item in listA)
        {
            if(!listB.Contains(item))
                list.Add(item);
        }

        return list;
    }
    

    public List<T> Union<T>(in List<T> listA, in List<T> listB)
    {
        var resultList = new List<T>();
        resultList.AddRange(listA);
        foreach (var item in listB)
            if (!listA.Contains(item))
                resultList.Add(item);
        
        return resultList;
    }
    
    
}