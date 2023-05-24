using System.Collections.Generic;

public class ObjectPool<T>
{
    private List<T> pool = new List<T>();
    
    public void AddObjectPool(T poolObject)
    {
        pool.Add(poolObject);
    }

    public List<T> GetObjectPool()
    {
        return pool;
    }
}